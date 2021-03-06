﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YSAPI.Service;
using YSAPI.Service.AccessToken;
using YSAPI.Service.Common;

namespace YSAPI.UnitTest
{
    [TestClass]
    public class YSAPIManagerTest
    {
        private string accessToken = "at.7xw2oq1h0m76ym5ca25pcvzc67vee1v4-4n59wd4xow-16m5nrp-o21yks6md";
        private string appKey = "a1eb3bf857704945ae8916663cdd08b5";
        private  string appSecret = "9710599d3628132bf2e4de7248009cd4";


        /// <summary>
        /// 获取accessToken
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task TestGetAccessToken()
        {
            var result = await YSAPIManager.GetAccessTokenAsync(appKey, appSecret);
            Assert.IsTrue(result.code.Equals("200"));
        }
        /// <summary>
        /// 获取用户下直播视频列表
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task TestGetVideoList()
        {
            var result = await YSAPIManager.GetVideoList(accessToken,0,50);
            Assert.IsTrue(result.code.Equals("200"));
        }
        /// <summary>
        /// 获取指定有效期的直播地址
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task TestGetVideo()
        {
            var result = await YSAPIManager.GetVideo(accessToken, "674412071",1,null);
            Assert.IsTrue(result.code.Equals("200"));
        }
        /// <summary>
        /// 指定有效期
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task TestGetVideoLimited()
        {
            var result = await YSAPIManager.GetVideo(accessToken, "674412071", 1,300);
            Assert.IsTrue(result.code.Equals("200"));
        }
        /// <summary>
        /// 批量获取设备的直播地址信息
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task TestGetLiveAddress()
        {
           List<SourceModel> list=new List<SourceModel>();
            SourceModel model=new SourceModel();
            model.deviceSerial = "574364918";
            model.channelNo = 16;
            list.Add(model);
            var result = await YSAPIManager.GetLiveAddressList(accessToken, list);
            Assert.IsTrue(result.code.Equals("200"));
        }
        /// <summary>
        /// 查询账号下流量消耗汇总
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task TestGetUserTotalTraffic()
        {
            var result = await YSAPIManager.GetUserTotalTraffic(accessToken);
            Assert.IsTrue(result.code.Equals("200"));
        }
        /// <summary>
        /// 根据序列号和通道号批量关闭直播功能
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task TestCloseVideoLive()
        {
            List<SourceModel> list=new List<SourceModel>();
            SourceModel model=new SourceModel();
            model.deviceSerial = "574364918";
            model.channelNo = 12;
            list.Add(model);
            SourceModel model2 = new SourceModel();
            model2.deviceSerial = "574364918";
            model2.channelNo = 14;
            list.Add(model2);
            var result = await YSAPIManager.CloseVideoLive(accessToken,list);
            Assert.IsTrue(result.code.Equals("200"));
        }
        /// <summary>
        /// 根据序列号和通道号批量开通直播功能（只支持可观看视频的设备）
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task TestOpenVideoLive()
        {
            List<SourceModel> list = new List<SourceModel>();
            SourceModel model = new SourceModel();
            model.deviceSerial = "574364918";
            model.channelNo = 12;
            list.Add(model);
            SourceModel model2 = new SourceModel();
            model2.deviceSerial = "574364918";
            model2.channelNo = 14;
            list.Add(model2);
            var result = await YSAPIManager.OpenVideoLive(accessToken, list);
            Assert.IsTrue(result.code.Equals("200"));
        }

    }
}
