using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YSAPI.Service.Common;

namespace YSAPI.Service.WebApi.Model
{
    public class LiveAddressResultModel:ResponseModel
    {
        public List<LiveAddressResultData> data { get; set; }
    }

    public class LiveAddressResultData
    {
        /// <summary>
        /// 状态码，参考下方返回码。优先判断该错误码，返回200即表示成功。
        /// </summary>
        public string ret { get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        public string desc { get; set; }

        /// <summary>
        /// 设备序列号
        /// </summary>
        public string deviceSerial { get; set; }

        /// <summary>
        /// 通道号
        /// </summary>
        public int channelNo { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        public string deviceName { get; set; }
        /// <summary>
        /// HLS流畅直播地址
        /// </summary>
        public string hls { get; set; }
        /// <summary>
        /// HLS高清直播地址
        /// </summary>
        public string hlsHd { get; set; }
        /// <summary>
        /// RTMP流畅直播地址
        /// </summary>
        public string rtmp { get; set; }
        /// <summary>
        /// RTMP高清直播地址
        /// </summary>
        public string rtmpHd { get; set; }
        /// <summary>
        /// 开始时间，long格式如1472694964067，精确到毫秒。expireTime参数为空时该字段无效
        /// </summary>
        public long beginTime { get; set; }
        /// <summary>
        /// 过期时间，long格式如1472794964067，精确到毫秒。expireTime参数为空时该字段无效
        /// </summary>
        public long endTime { get; set; }
        /// <summary>
        /// 地址使用状态：0-未使用或直播已关闭，1-使用中，2-已过期，3-直播已暂停，
        /// 0状态不返回地址，其他返回。-1表示ret不返回200时的异常情况，参考ret返回错误码。
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// 地址异常状态：0-正常，1-设备不在线，2-设备开启视频加密，3-设备删除，4-失效，
        /// 5-未绑定，6-账户下流量已超出，7-设备接入限制，
        /// 0/1/2/6状态返回地址，其他不返回。-1表示ret不返回200时的异常情况，参考ret返回错误码。
        /// </summary>
        public int exception { get; set; }
    }


  
}
