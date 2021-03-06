﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using CodeSmith.Data.Linq;
using CodeSmith.Data.Linq.Dynamic;

namespace Tracker.Core.Data
{
    /// <summary>
    /// The query extension class for Guid.
    /// </summary>
    public static partial class GuidExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static Tracker.Core.Data.Guid GetByKey(this IQueryable<Tracker.Core.Data.Guid> queryable, System.Guid id)
        {
            var entity = queryable as System.Data.Linq.Table<Tracker.Core.Data.Guid>;
            if (entity != null && entity.Context.LoadOptions == null)
                return Query.GetByKey.Invoke((Tracker.Core.Data.TrackerDataContext)entity.Context, id);

            return queryable.FirstOrDefault(g => g.Id == id);
        }

        /// <summary>
        /// Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        /// </summary>
        /// <param name="table">Represents a table for a particular type in the underlying database containing rows are to be deleted.</param>
        /// <returns>The number of rows deleted from the database.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static int Delete(this System.Data.Linq.Table<Tracker.Core.Data.Guid> table, System.Guid id)
        {
            return table.Delete(g => g.Id == id);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Guid.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Core.Data.Guid> ById(this IQueryable<Tracker.Core.Data.Guid> queryable, System.Guid id)
        {
            return queryable.Where(g => g.Id == id);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Guid.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Core.Data.Guid> ById(this IQueryable<Tracker.Core.Data.Guid> queryable, ComparisonOperator comparisonOperator, System.Guid id)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                case ComparisonOperator.GreaterThanOrEquals:
                case ComparisonOperator.LessThan:
                case ComparisonOperator.LessThanOrEquals:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support System.Guid type.", "comparisonOperator");
                case ComparisonOperator.NotEquals:
                    return queryable.Where(g => g.Id != id);
                default:
                    return queryable.Where(g => g.Id == id);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Guid.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="id">Id to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Core.Data.Guid> ById(this IQueryable<Tracker.Core.Data.Guid> queryable, System.Guid id, params System.Guid[] additionalValues)
        {
            var idList = new List<System.Guid> { id };

            if (additionalValues != null)
                idList.AddRange(additionalValues);

            if (idList.Count == 1)
                return queryable.ById(idList[0]);

            return queryable.ById(idList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Guid.Id"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Core.Data.Guid> ById(this IQueryable<Tracker.Core.Data.Guid> queryable, IEnumerable<System.Guid> values)
        {
            return queryable.Where(g => values.Contains(g.Id));
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Guid.AlternateId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="alternateId">AlternateId to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Core.Data.Guid> ByAlternateId(this IQueryable<Tracker.Core.Data.Guid> queryable, System.Guid? alternateId)
        {
            // support nulls
            return alternateId == null 
                ? queryable.Where(g => g.AlternateId == null) 
                : queryable.Where(g => g.AlternateId == alternateId);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Guid.AlternateId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="alternateId">AlternateId to search for. This is on the right side of the operator.</param>
        /// <param name="comparisonOperator">The comparison operator.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Core.Data.Guid> ByAlternateId(this IQueryable<Tracker.Core.Data.Guid> queryable, ComparisonOperator comparisonOperator, System.Guid? alternateId)
        {
            if (alternateId == null && comparisonOperator != ComparisonOperator.Equals && comparisonOperator != ComparisonOperator.NotEquals)
                throw new ArgumentNullException("alternateId", "Parameter 'alternateId' cannot be null with the specified ComparisonOperator.  Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support null.");

            switch (comparisonOperator)
            {
                case ComparisonOperator.GreaterThan:
                case ComparisonOperator.GreaterThanOrEquals:
                case ComparisonOperator.LessThan:
                case ComparisonOperator.LessThanOrEquals:
                    throw new ArgumentException("Parameter 'comparisonOperator' must be ComparisonOperator.Equals or ComparisonOperator.NotEquals to support System.Guid? type.", "comparisonOperator");
                case ComparisonOperator.NotEquals:
                    return alternateId == null 
                        ? queryable.Where(g => g.AlternateId != null) 
                        : queryable.Where(g => g.AlternateId != alternateId);
                default:
                    return alternateId == null 
                        ? queryable.Where(g => g.AlternateId == null) 
                        : queryable.Where(g => g.AlternateId == alternateId);
            }
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Guid.AlternateId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="alternateId">AlternateId to search for.</param>
        /// <param name="additionalValues">Additional values to search for.</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Core.Data.Guid> ByAlternateId(this IQueryable<Tracker.Core.Data.Guid> queryable, System.Guid? alternateId, params System.Guid?[] additionalValues)
        {
            var alternateIdList = new List<System.Guid?> { alternateId };

            if (additionalValues != null)
                alternateIdList.AddRange(additionalValues);
            else
                alternateIdList.Add(null);

            if (alternateIdList.Count == 1)
                return queryable.ByAlternateId(alternateIdList[0]);

            return queryable.ByAlternateId(alternateIdList);
        }

        /// <summary>
        /// Gets a query for <see cref="Tracker.Core.Data.Guid.AlternateId"/>.
        /// </summary>
        /// <param name="queryable">Query to append where clause.</param>
        /// <param name="values">The values to search for..</param>
        /// <returns><see cref="IQueryable"/> with additional where clause.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static IQueryable<Tracker.Core.Data.Guid> ByAlternateId(this IQueryable<Tracker.Core.Data.Guid> queryable, IEnumerable<System.Guid?> values)
        {
            // creating dynmic expression to support nulls
            var expression = DynamicExpression.BuildExpression<Tracker.Core.Data.Guid, bool>("AlternateId", values);
            return queryable.Where(expression);
        }

        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
            internal static readonly Func<Tracker.Core.Data.TrackerDataContext, System.Guid, Tracker.Core.Data.Guid> GetByKey =
                System.Data.Linq.CompiledQuery.Compile(
                    (Tracker.Core.Data.TrackerDataContext db, System.Guid id) =>
                        db.Guid.FirstOrDefault(g => g.Id == id));

        }
        #endregion
    }
}
#pragma warning restore 1591

