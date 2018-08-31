using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using YSAPI.Service.AccessToken;
using YSAPI.Service.Common;
using YSAPI.Service.WebApi.Model;

namespace YSAPI.Service
{
    /// <summary>
    /// 萤石api的H5/Web相关接口
    /// </summary>
    public static class YSAPIManager
    {

        /// <summary>
        /// 获取AccessToken
        /// 7天过期，调用者自己处理
        /// </summary>
        /// <param name="appKey"></param>
        /// <param name="appSecret"></param>
        /// <returns></returns>
        public static async Task<GetTokenResponseModel> GetAccessToken(string appKey, string appSecret)
        {
            var url = "https://open.ys7.com/api/lapp/token/get";
            string data = $"appKey={appKey}&appSecret={appSecret}";
            var result = await RequestUtility.PostAsync<GetTokenResponseModel>(data, url);
            return result;
        }

        /// <summary>
        /// 获取用户下直播视频列表
        /// </summary>
        /// <param name="accessToken">授权过程获取的access_token</param>
        /// <param name="pageStart">分页起始页，从0开始</param>
        /// <param name="pageSize">分页大小，默认为10，最大为50</param>
        /// <returns></returns>
        public static async Task<VideoListResultModel> GetVideoList(string accessToken, int pageStart = 0, int pageSize = 10)
        {
            var url = "https://open.ys7.com/api/lapp/live/video/list";
            string data = $"accessToken={accessToken}&pageStart={pageStart}&pageSize={pageSize}";
            var result = await RequestUtility.PostAsync<VideoListResultModel>(data, url);
            return result;
        }
        /// <summary>
        /// 获取指定有效期的直播地址
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="deviceSerial">设备序列号</param>
        /// <param name="channelNo">通道号，IPC设备填1</param>
        /// <param name="expireTime">地址过期时间：单位秒数，最大默认62208000（即720天），最小默认300（即5分钟）。非必选参数，为空时返回对应设备和通道的永久地址</param>
        /// <returns></returns>
        public static async Task<VideoResultModel> GetVideo(string accessToken, string deviceSerial, int channelNo, int? expireTime)
        {
            var url = "https://open.ys7.com/api/lapp/live/address/limited";
            string data = expireTime == null ? $"accessToken={accessToken}&deviceSerial={deviceSerial}&channelNo={channelNo}" : $"accessToken={accessToken}&deviceSerial={deviceSerial}&channelNo={channelNo}&expireTime={expireTime}";
            var result = await RequestUtility.PostAsync<VideoResultModel>(data, url);
            return result;
        }

        /// <summary>
        /// 批量获取设备的直播地址信息
        /// 该接口用于根据序列号和通道号批量获取设备的直播地址信息，
        /// 开通直播后才可获取直播地址 该接口获取直播地址固定不变,永久有效。
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public static async Task<LiveAddressResultModel> GetLiveAddressList(string accessToken, List<SourceModel> list)
        {
            var url = "https://open.ys7.com/api/lapp/live/address/get";
            var source = RequestUtility.GetRequestData(list);
            string data = $"accessToken={accessToken}&source={source}";
            var result = await RequestUtility.PostAsync<LiveAddressResultModel>(data, url);
            return result;
        }

        /// <summary>
        /// 根据序列号和通道号批量开通直播功能（只支持可观看视频的设备）
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public static async Task<OpenLiveResultModel> OpenVideoLive(string accessToken, List<SourceModel> list)
        {
            var url = "https://open.ys7.com/api/lapp/live/video/open";
            var source = RequestUtility.GetRequestData(list);
            string data = $"accessToken={accessToken}&source={source}";
            var result = await RequestUtility.PostAsync<OpenLiveResultModel>(data, url);
            return result;
        }

        /// <summary>
        /// 根据序列号和通道号批量关闭直播功能
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public static async Task<OpenLiveResultModel> CloseVideoLive(string accessToken, List<SourceModel> list)
        {
            var url = "https://open.ys7.com/api/lapp/live/video/close";
            var source = RequestUtility.GetRequestData(list);
            string data = $"accessToken={accessToken}&source={source}";
            var result = await RequestUtility.PostAsync<OpenLiveResultModel>(data, url);
            return result;
        }

        /// <summary>
        /// 查询账号下流量消耗汇总
        /// </summary>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public static async Task<UserTrafficTotalResultModel> GetUserTotalTraffic(string accessToken)
        {
            var url = "https://open.ys7.com/api/lapp/traffic/user/total";
            string data = $"accessToken={accessToken}";
            var result = await RequestUtility.PostAsync<UserTrafficTotalResultModel>(data, url);
            return result;
        }
        /// <summary>
        /// 查询账户下流量消耗详情
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="startTime">开始时间，时间格式为1457420564508，精确到毫秒，默认为当前日期往前推算1周。最多只能查询当前日期往前1周内的数据</param>
        /// <param name="endTime">结束时间，时间格式为1457420564508，精确到毫秒，默认为当前日期往前推算1天。只能查询1天前的数据</param>
        /// <param name="pageStart">分页起始页，从0开始，默认为0</param>
        /// <param name="pageSize">分页大小，默认为10，最大为50</param>
        /// <returns></returns>
        public static async Task<UserTrafficDetailResultModel> GetUserTrafficDetail(string accessToken, long startTime, long endTime, int pageStart, int pageSize)
        {
            var url = "https://open.ys7.com/api/lapp/traffic/user/detail";
            string data =
                $"accessToken={accessToken}&startTime={startTime}&endTime={endTime}&pageStart={pageStart}&pageSize={pageSize}";
            var result = await RequestUtility.PostAsync<UserTrafficDetailResultModel>(data, url);
            return result;
        }
        /// <summary>
        /// 查询账户下某天流量消耗详情
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="flowTime">日期，时间格式为1457420564508，精确到毫秒，默认为当前日期往前1天。只能查询当前日期往前推算7天内、1天前的数据</param>
        /// <param name="pageStart">分页起始页，从0开始，默认为0</param>
        /// <param name="pageSize">分页大小，默认为10，最大为50</param>
        /// <returns></returns>
        public static async Task<UserSomeDayTrafficDetailResultModel> GetUserDayTrafficDetail(string accessToken, long flowTime, int pageStart, int pageSize)
        {
            var url = "https://open.ys7.com/api/lapp/traffic/day/detail";
            string data = $"accessToken={accessToken}&flowTime={flowTime}&pageStart={pageStart}&pageSize={pageSize}";
            var result = await RequestUtility.PostAsync<UserSomeDayTrafficDetailResultModel>(data, url);
            return result;
        }

        /// <summary>
        /// 查询指定设备在某一时间段消耗流量数据
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="deviceSerial">设备序列号</param>
        /// <param name="startTime">开始时间，时间格式为1457420564508，精确到毫秒，默认为当前日期往前推算1周。最多只能查询当前日期往前1周内的数据</param>
        /// <param name="endTime">结束时间，时间格式为1457420564508，精确到毫秒，默认为当前日期往前推算1天。只能查询1天前的数据</param>
        /// <param name="pageStart">分页起始页，从0开始，默认为0</param>
        /// <param name="pageSize">分页大小，默认为10，最大为50</param>
        /// <returns></returns>
        public static async Task<DeviceTrafficDetailResultModel> GetDeviceTrafficDetail(string accessToken, string deviceSerial, string startTime, string endTime, string pageStart, string pageSize)
        {
            var url = "https://open.ys7.com/api/lapp/traffic/device/detail";
            string data =
                $"accessToken={accessToken}&deviceSerial={deviceSerial}&startTime={startTime}&endTime={endTime}&pageStart={pageStart}&pageSize={pageSize}";
            var result = await RequestUtility.PostAsync<DeviceTrafficDetailResultModel>(data, url);
            return result;
        }
    }
}
