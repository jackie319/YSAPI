using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YSAPI.Service.Common;

namespace YSAPI.Service.WebApi.Model
{
    public class DeviceTrafficDetailResultModel:ResponseModel
    {
        public List<DeviceTrafficDetailResultData> data { get; set; }
    }

    public class DeviceTrafficDetailResultData
    {
        /// <summary>
        /// 日期
        /// </summary>
        public long flowDate { get; set; }
        /// <summary>
        /// 设备序列号
        /// </summary>
        public string deviceSerial { get; set; }
        /// <summary>
        /// 通道号
        /// </summary>
        public int channelNo { get; set; }
        /// <summary>
        /// 轻应用HLS地址预览消耗，单位字节
        /// </summary>
        public long hlsFlow { get; set; }
        /// <summary>
        /// APP应用预览消耗，单位字节
        /// </summary>
        public long appFlow { get; set; }
        /// <summary>
        /// 轻应用RTMP地址预览消耗，单位字节
        /// </summary>
        public long rtmpFlow { get; set; }
        /// <summary>
        /// 流量消耗汇总，单位字节
        /// </summary>
        public long flowCount { get; set; }
    }
}
