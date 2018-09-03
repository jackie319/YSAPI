using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YSAPI.Service.Common;

namespace YSAPI.Service.WebApi.Model
{
   public class DeviceCameraListResultModel:ResponseModel
    {
        public List<DeviceCameraListResultData> data { get; set; }
    }
    public class DeviceCameraListResultData
    {
        /// <summary>
        /// 设备序列号
        /// </summary>
        public string deviceSerial { get; set; }
        /// <summary>
        /// IPC序列号
        /// </summary>
        public string ipcSerial { get; set; }
        /// <summary>
        /// 通道号
        /// </summary>
        public int channelNo { get; set; }
        /// <summary>
        /// 设备名
        /// </summary>
        public string deviceName { get; set; }
        /// <summary>
        /// 通道名
        /// </summary>
        public string channelName { get; set; }
        /// <summary>
        /// 在线状态：0-不在线，1-在线,-1设备未上报
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// 分享状态：1-分享所有者，0-未分享，2-分享接受者（表示此摄像头是别人分享给我的）
        /// </summary>
        public string isShared { get; set; }
        /// <summary>
        /// 图片地址（大图），若在萤石客户端设置封面则返回封面图片，未设置则返回默认图片
        /// </summary>
        public string picUrl { get; set; }
        /// <summary>
        /// 是否加密，0：不加密，1：加密
        /// </summary>
        public int isEncrypt { get; set; }
        /// <summary>
        /// 视频质量：0-流畅，1-均衡，2-高清，3-超清
        /// </summary>
        public int videoLevel { get; set; }
        /// <summary>
        /// 当前通道是否关联IPC：true-是，false-否。设备未上报或者未关联都是false
        /// </summary>
        public Boolean relatedIpc { get; set; }
    }
}
