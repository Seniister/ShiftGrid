﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShiftGrid.Test.NET.Tests.SQLServer
{
    [TestClass]
    public class Pagination : ShiftGrid.Test.Shared.Tests.Pagination
    {
        public Pagination() : base(typeof(EF.DB), new Utils(typeof(EF.DB)))
        {

        }
    }
}