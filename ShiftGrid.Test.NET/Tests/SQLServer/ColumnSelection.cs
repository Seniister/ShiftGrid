﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShiftGrid.Test.NET.Tests.SQLServer
{
    [TestClass]
    public class ColumnSelection : Tests.ColumnSelection
    {
        public ColumnSelection() : base(typeof(EF.DB))
        {

        }
    }
}