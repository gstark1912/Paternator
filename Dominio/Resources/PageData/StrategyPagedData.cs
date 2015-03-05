using Dominio.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace Dominio.Resources
{
    public class StrategyPagedData
    {
        public PagedDataParameters Parameters { get; set; }

        public StrategyPagedData(PagedDataParameters parameters)
        {
            Parameters = parameters;
        }

        /// <summary>
        /// Genera la creación de la query a aplicar a partir de la ya existente enviada
        /// en el parámetro "source".
        /// Soporta la obtención de propiedades de una dependencia de la entidad,
        /// separadas por punto.
        /// Ej: Si se quisiera ordenar por la propiedad MainEntity.ChildEntity.PropertyName, debería ser
        /// enviado en el OrderFieldName de los parameters un string: "ChildEntity.PropertyName".
        /// </summary>          
        public IQueryable<T> ApplyStrategy<T>(IQueryable<T> source)
        {
            var parameter = Expression.Parameter(typeof(T), "Entity");
            var propertyName = this.Parameters.OrderField;
            PropertyInfo property;
            Expression propertyAccess;

            /// Identifica si se refiere a una propiedad de la entidad, o
            /// a una propiedad de una entidad relacionada.
            if (propertyName.Contains('.'))
            {
                String[] childProperties = propertyName.Split('.');
                property = typeof(T).GetProperty(childProperties[0]);
                propertyAccess = Expression.MakeMemberAccess(parameter, property);
                for (int i = 1; i < childProperties.Length; i++)
                {
                    property = property.PropertyType.GetProperty(childProperties[i]);
                    propertyAccess = Expression.MakeMemberAccess(propertyAccess, property);
                }
            }
            else
            {
                property = typeof(T).GetProperty(propertyName);
                propertyAccess = Expression.MakeMemberAccess(parameter, property);
            }

            LambdaExpression expresion = Expression.Lambda(propertyAccess, parameter);
            string orderby = Parameters.OrderDirection == Enums.OrderBy.Descendant ? "OrderByDescending" : "OrderBy";
            /// Creación de la expresión a agregar a la query, ya con la obtención
            /// de las propiedades en una Expresión Lambda.
            MethodCallExpression resultExp = Expression.Call(typeof(Queryable), orderby,
                            new Type[] { typeof(T), property.PropertyType },
                            source.Expression, Expression.Quote(expresion));

            return (source.Provider.CreateQuery<T>(resultExp) as IQueryable<T>)
                        .Skip((this.Parameters.Page - 1) * this.Parameters.Rows) // Implementación de la página.
                        .Take(this.Parameters.Rows); // Implementación de la cantidad de filas por página.

        }
    }
}
