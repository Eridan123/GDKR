using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Gkdr.Consumer.Data
{
    public static class DomainExtensions
    {
        public static DataTableResponce CreateDataTable<T>(this IQueryable<T> source, Datatable datatable)
        {
            var dir = datatable.order[0].dir.Equals("asc");
            var prop = datatable.columns[datatable.order[0].column].name;
            var resp = new DataTableResponce { filter = new List<string>() };
            var totalResultsCount = source.Count();
            var query = source;

            foreach (var col in datatable.columns)
            {
                if (col.searchable && !string.IsNullOrEmpty(col.search.value))
                {
                    var colName = col.name;
                    var type = typeof(T).GetProperty(col.name)?.PropertyType;

                    if (type == typeof(DateTime) || type == typeof(DateTime?))
                    { // Dates
                        query = query.Where(sc => EF.Property<DateTime>(sc, col.name) == DateTime.Parse(col.search.value));
                    }
                    else if (type == typeof(int) || type == typeof(int?))
                    { // Ints
                        query = query.Where(sc => Convert.ToString(EF.Property<int>(sc, col.name)) == col.search.value);
                    }
                    else if (type == typeof(string))
                    { // Strings
                        query = query.Where(sc => EF.Property<string>(sc, col.name).Contains(col.search.value.ToUpper()));
                    }
                    else
                    { // Object Types
                        query = query.Where(sc => EF.Property<int>(sc, col.name) == Convert.ToInt32(col.search.value));
                    }

                    resp.filter.Add( colName + "=\"" + col.search.value + "\"");
                }
            }

            {
                var type = typeof(T).GetProperty(prop)?.PropertyType;
                var colName = prop;

                if (type == typeof(DateTime) || type == typeof(DateTime?) || type == typeof(int?) || type == typeof(int) || type == typeof(string))
                {
                    query = dir
                        ? query.OrderBy(sc => EF.Property<object>(sc, prop))
                        : query.OrderByDescending(sc => EF.Property<object>(sc, prop));
                }
                else
                {
                    query = dir
                        ? query.OrderBy(sc => EF.Property<object>(sc, prop))
                        : query.OrderByDescending(sc => EF.Property<object>(sc, prop));
                }
                resp.order = colName;

            }
            var filteredResultsCount = query;
                query = query.Skip(datatable.start).Take(datatable.length);

            resp.draw = datatable.draw;
            resp.recordsTotal = totalResultsCount;
            resp.recordsFiltered = filteredResultsCount.Count();
            resp.data = query.ToList();

            return resp;
        }
    }
}