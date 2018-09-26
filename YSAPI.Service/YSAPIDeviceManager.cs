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
        public static async Task<ResponseModel> DeleteDevice(string accessToken, string deviceSerial)
        {
            var url = "https://open.ys7.com/api/lapp/device/delete";
            string data = $"accessToken={accessToken}&deviceSerial={deviceSerial}";
            var result = await RequestUtility.PostAsync<ResponseModel>(data, url);
            return result;
        }
        /// <summary>
        /// 设备抓拍图片
        /// 抓拍设备当前画面，该接口仅适用于IPC或者关联IPC的DVR设备，该接口并非预览时的截图功能。
        /// 海康型号设备可能不支持萤石协议抓拍功能，使用该接口可能返回不支持或者超时。
        /// 注意：设备抓图能力有限，请勿频繁调用，频繁调用将会被拉入限制黑名单,建议调用的间隔为4s左右。
        /// 抓拍后的图片路径，图片保存有效期为2小时
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="deviceSerial"></param>
        /// <param name="channelNo"></param>
        /// <returns></returns>
        public static async Task<CaptureDeviceResultModel> CaptureDevice(string accessToken, string deviceSerial, int channelNo)
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
        public static async Task<DeviceCameraListResultModel> GetDeviceCameraList(string accessToken, string deviceSerial)
        {
            var url = "https://open.ys7.com/api/lapp/device/camera/list";
            string data = $"accessToken={accessToken}&deviceSerial={deviceSerial}";
            var result = await RequestUtility.PostAsync<DeviceCameraListResultModel>(data, url);
            return result;
        }

        /// <summary>
        /// 获取设备全天录像开关状态（需要设备支持全天录像功能）
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="deviceSerial"></param>
        /// <returns></returns>
        public static async Task<FullDayRecordStatusResutlModel> GetFullDayRecordStatus(string accessToken, string deviceSerial)
        {
            var url = "https://open.ys7.com/api/lapp/device/fullday/record/switch/status";
            string data = $"accessToken={accessToken}&deviceSerial={deviceSerial}";
            var result = await RequestUtility.PostAsync<FullDayRecordStatusResutlModel>(data, url);
            return result;
        }
        /// <summary>
        /// 设置全天录像开关状态（需要设备支持全天录像功能）
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="deviceSerial"></param>
        /// <param name="enable">状态：0-关闭，1-开启</param>
        /// <param name="channelNo">通道号，不传表示设备本身</param>
        /// <returns></returns>
        public static async Task<ResponseModel> SetFullDayRecordStaus(string accessToken, string deviceSerial, int enable, int? channelNo)
        {
            var url = "https://open.ys7.com/api/lapp/device/fullday/record/switch/set";
            string data = channelNo == null ? $"accessToken={accessToken}&deviceSerial={deviceSerial}&enable={enable}"
                : $"accessToken={accessToken}&deviceSerial={deviceSerial}&enable={enable}&channelNo={channelNo}";
            var result = await RequestUtility.PostAsync<ResponseModel>(data, url);
            return result;
        }

        /// <summary>
        /// 查询用户下设备基本信息列表
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="pageStart"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static async Task<DeviceListResultModel> GetDeviceList(string accessToken, int pageStart, int pageSize)
        {
            var url = "https://open.ys7.com/api/lapp/device/list";
            string data = $"accessToken={accessToken}&pageStart={pageStart}&pageSize={pageSize}";
            var result = await RequestUtility.PostAsync<DeviceListResultModel>(data, url);
            return result;
        }

        /// <summary>
        /// NVR设备关联IPC
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="deviceSerial"></param>
        /// <param name="ipcSerial"></param>
        /// <param name="channelNo"></param>
        /// <returns></returns>
        public static async Task<ResponseModel> AddIPC(string accessToken, string deviceSerial, string ipcSerial, int channelNo)
        {
            var url = "https://open.ys7.com/api/lapp/device/ipc/add";
            string data = $"accessToken={accessToken}&deviceSerial={deviceSerial}&ipcSerial={ipcSerial}&channelNo={channelNo}";
            var result = await RequestUtility.PostAsync<ResponseModel>(data, url);
            return result;
        }

        /// <summary>
        /// 该接口用户根据设备序列号查询设备能力集
        /// 能力集说明中有的,而返回字段中没有的那些能力默认不支持
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="deviceSerial"></param>
        /// <returns></returns>

        public static async Task<DeviceCapacityResultModel> DeviceCapacity(string accessToken, string deviceSerial)
        {
            var url = "https://open.ys7.com/api/lapp/device/capacity";
            var data = $"accessToken={accessToken}&deviceSerial={deviceSerial}";
            var result = await RequestUtility.PostAsync<DeviceCapacityResultModel>(data, url);
            return result;
        }
        /// <summary>
        /// 获取用户下的摄像头列表
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="pageStart"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static async Task<CameraListResultModel> GetCameraList(string accessToken,int pageStart,int pageSize)
        {
            var url = "https://open.ys7.com/api/lapp/camera/list";
            var data = $"accessToken={accessToken}&pageStart={pageStart}&pageSize={pageSize}";
            var result = await RequestUtility.PostAsync<CameraListResultModel>(data,url);
            return result;
        }

    }
}
