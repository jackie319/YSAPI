using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YSAPI.Service.Common;
using YSAPI.Service.HttpApi.Model;
using YSAPI.Service.WebApi.Model;

namespace YSAPI.Service
{
    /// <summary>
    ///  萤石api的设备相关接口
    /// </summary>
    public static class YSAPIDeviceManager
    {
        /// <summary>
        /// 添加设备到账号下
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="deviceSerial">设备序列号</param>
        /// <param name="validateCode">设备验证码，设备机身上的六位大写字母</param>
        /// <returns></returns>
        public static async Task<ResponseModel> AddDevice(string accessToken, string deviceSerial, string validateCode)
        {
            var url = "https://open.ys7.com/api/lapp/device/add";
            string data = $"accessToken={accessToken}&deviceSerial={deviceSerial}&validateCode={validateCode}";
            var result = await RequestUtility.PostAsync<ResponseModel>(data, url);
            return result;
        }
        /// <summary>
        /// 删除设备
        /// 删除账号下设备（为保证该接口正常使用，请勿在萤石云APP开启终端绑定。
        /// 如果该接口报错20031请手机登录萤石云视频客户端“我的”--“通用设置”--“账号安全”--“终端绑定”，关闭即可）
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="deviceSerial">设备序列号</param>
        /// <returns></returns>
        public static async Task<ResponseModel> DeleteDevice(string accessToken,string deviceSerial)
        {
            var url = "https://open.ys7.com/api/lapp/device/delete";
            string data = $"accessToken={accessToken}&deviceSerial={deviceSerial}";
            var result =await RequestUtility.PostAsync<ResponseModel>(data,url);
            return result;
        }
        /// <summary>
        /// 设备抓拍图片
        /// 抓拍设备当前画面，该接口仅适用于IPC或者关联IPC的DVR设备，该接口并非预览时的截图功能。
        /// 海康型号设备可能不支持萤石协议抓拍功能，使用该接口可能返回不支持或者超时。
        /// 注意：设备抓图能力有限，请勿频繁调用，频繁调用将会被拉入限制黑名单,建议调用的间隔为4s左右。
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="deviceSerial"></param>
        /// <param name="channelNo"></param>
        /// <returns></returns>
        public static async Task<CaptureDeviceResultModel> CaptureDevice(string accessToken,string deviceSerial,int channelNo)
        {
            var url = "https://open.ys7.com/api/lapp/device/capture";
            string data = $"accessToken={accessToken}&deviceSerial={deviceSerial}&channelNo={channelNo}";
            var result = await RequestUtility.PostAsync<CaptureDeviceResultModel>(data, url);
            return result;
        }
        /// <summary>
        /// 获取指定设备的通道信息
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="deviceSerial">设备序列号</param>
        /// <returns></returns>
        public static async Task<DeviceCameraListResultModel> GetDeviceCameraList(string accessToken,string deviceSerial)
        {
            var url = "https://open.ys7.com/api/lapp/device/camera/list";
            string data = $"accessToken={accessToken}&deviceSerial={deviceSerial}";
            var result = await RequestUtility.PostAsync<DeviceCameraListResultModel>(data,url);
            return result;
        }
    }
}
