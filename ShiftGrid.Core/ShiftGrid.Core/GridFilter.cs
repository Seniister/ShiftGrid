﻿using System.Collections.Generic;

namespace ShiftGrid.Core
{
    public class GridFilter
    {
        public string Field { get; set; }
        public object Value { get; set; }
        public string Operator { get; set; }
        public List<GridFilter> OR { get; set; }
    }
}
