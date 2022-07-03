﻿using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ShiftSoftware.ShiftGrid.Core
{
    public static class Extensions
    {
        public static Grid<T> ToShiftGrid<T>(this IQueryable<T> select, string stableSortField, SortDirection stableSortDirection = SortDirection.Ascending, GridConfig gridConfig = null)
        {
            return new Grid<T>
            {
                StableSort = new GridSort { Field = stableSortField, SortDirection = stableSortDirection },
                Select = select
            }.Init(gridConfig);
        }

        public static async Task<Grid<T>> ToShiftGridAsync<T>(this IQueryable<T> select, string stableSortField, SortDirection stableSortDirection = SortDirection.Ascending, GridConfig gridConfig = null)
        {
            return await new Grid<T>
            {
                StableSort = new GridSort { Field = stableSortField, SortDirection = stableSortDirection },
                Select = select
            }.InitAsync(gridConfig);
        }

        public static Grid<T> ToShiftGrid<T>(this SelectAndSummarySelectCombo<T> summarySelectCombo, string stableSortField, SortDirection stableSortDirection = SortDirection.Ascending, GridConfig gridConfig = null)
        {
            return new Grid<T>()
            {
                StableSort = new GridSort { Field = stableSortField, SortDirection = stableSortDirection },
                Select = summarySelectCombo.Select,
                SummarySelect = summarySelectCombo.SummarySelect,
            }.Init(gridConfig);
        }

        public static async Task<Grid<T>> ToShiftGridAsync<T>(this SelectAndSummarySelectCombo<T> summarySelectCombo, string stableSortField, SortDirection stableSortDirection = SortDirection.Ascending, GridConfig gridConfig = null)
        {
            return await new Grid<T>()
            {
                StableSort = new GridSort { Field = stableSortField, SortDirection = stableSortDirection },
                Select = summarySelectCombo.Select,
                SummarySelect = summarySelectCombo.SummarySelect,
            }.InitAsync(gridConfig);
        }

        public class SelectAndSummarySelectCombo<T>
        {
            public IQueryable<T> Select { get; set; }
            public Expression<Func<IGrouping<int, T>, object>> SummarySelect { get; set; }
        }

        public static SelectAndSummarySelectCombo<T> SelectSummary<T>(this IQueryable<T> select, Expression<Func<IGrouping<int, T>, object>> summarySelect)
        {
            return new SelectAndSummarySelectCombo<T>
            {
                Select = select,
                SummarySelect = summarySelect
            };
        }
    }
}
