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
        private string accessToken = "at.95ar5xhx5jrz3jxc4mtn7gfc3l5wzf1s-1sclnfety1-08wit5o-jbz4hyqhz";
        private string appKey = "a1eb3bf857704945ae8916663cdd08b5";
        private string appSecret = "9710599d3628132bf2e4de7248009cd4";

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
        /// <summary>
        /// 关联ipc
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task TestAddIPC()
        {
            var result = await YSAPIDeviceManager.AddIPC(accessToken, "574364918", "674412071", 1);
            Assert.IsTrue(result.code.Equals("200"));
        }
        /// <summary>
        /// 设备能力集
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task TestDeviceCapacity()
        {
            var result = await YSAPIDeviceManager.DeviceCapacity(accessToken, "574364918");
            Assert.IsTrue(result.code.Equals("200"));
        }
        /// <summary>
        /// 抓拍
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task TestCaptureDevice()
        {
            var result = await YSAPIDeviceManager.CaptureDevice(accessToken, "574364918", 12);
            Assert.IsTrue(result.code.Equals("200"));
        }
        /// <summary>
        /// 获取用户下的摄像头列表
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task TestCameraList()
        {
            var result = await YSAPIDeviceManager.GetCameraList(accessToken,0,20);
            Assert.IsTrue(result.code.Equals("200"));
        }
    }

}
