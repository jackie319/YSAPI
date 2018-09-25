using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YSAPI.Service;

namespace YSAPI.UnitTest
{
    [TestClass]
    public class YSAPIDeviceManagerTest
    {
        private string accessToken = "at.bkg2aklx2q63pv6m1cjuz0zr7elvrfk3-837lk38ayj-0kob5wz-ntwvrsctb";
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

        [TestMethod]
        public async Task TestGetFullDayRecordStatus()
        {
            var result=await YSAPIDeviceManager.GetFullDayRecordStatus(accessToken, "574364918");
            Assert.IsTrue(result.code.Equals("200"));
        }

        [TestMethod]
        public async Task TestSetFullDayRecordStatus()
        {
            var result = await YSAPIDeviceManager.SetFullDayRecordStaus(accessToken, "674412071", 1,1);
            Assert.IsTrue(result.code.Equals("200"));
        }
        [TestMethod]
        public async Task TestGetDeviceList()
        {
            var result = await YSAPIDeviceManager.GetDeviceList(accessToken,1,10);
            Assert.IsTrue(result.code.Equals("200"));
        }
    }

}
