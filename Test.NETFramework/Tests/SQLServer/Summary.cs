﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.NETFramework.Tests.SQLServer
{
    [TestClass]
    public class Summary : ShiftGrid.Test.Shared.Tests.Summary
    {
        public Summary() : base(typeof(EF.DB), new Utils(typeof(EF.DB)))
        {

        }
    }
}