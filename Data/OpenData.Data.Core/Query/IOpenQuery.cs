﻿using OpenData.Common;
using OpenData.Data.Core.Query.OpenExpressions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace OpenData.Data.Core.Query
{
    public interface IOpenQuery<T>
    {
        SelectOpenExpression SelectExpression { get; }
        IWhereExpression WhereExpression { get; }
        TakeOpenExpression TakeExpression { get; }
        CallExpression CallExpression { get; }
        OrderOpenExpression OrderExpression { get; }

        IOpenQuery<T> OrderBy(string fieldName, bool descending = false);
        IOpenQuery<T> OrderBy<Key>(Expression<Func<T, Key>> keySelector, bool descending = false);
        IOpenQuery<T> Where<Key>(Expression<Func<T, Key>> keySelector, object value, CompareType type);
        IOpenQuery<T> Where(string fieldName, object value, CompareType type);
        IOpenQuery<T> Where(Expression<Func<T, bool>> where);
        IOpenQuery<T> Or(IWhere<T> query);
        int Count();
        T First();
        T Last();
        IEnumerable<T> ToList(int skip = 0, int take = 0);
        PagedList<T> ToPageList(int index, int pageSize = 10);
    }
}