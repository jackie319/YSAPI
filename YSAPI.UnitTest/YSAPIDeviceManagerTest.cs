﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace YSAPI.UnitTest
{
    [TestClass]
    public class YSAPIDeviceManagerTest
    {
        private string accessToken = "at.7ajniaj94z2dc4669mhizb9jdvfj1wn7-35z3ngq4m6-116rpuj-ze1fmbsjb";
        private string appKey = "6767e01d34054cd8bbdfb17eb97eda8e";
        private string appSecret = "ef4b42d12163a46f7249447d555ad071";

        [TestMethod]
        public void TestTime()
        {
            long time = 1470810222045;
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            TimeSpan toNow = TimeSpan.FromMilliseconds(time);
            var now=dtStart.Add(toNow);
            Assert.IsTrue(1 == 1);
        }
    }

}
