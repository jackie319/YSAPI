using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YSAPI.Service.Common;

namespace YSAPI.Service.WebApi.Model
{
    public class UserTrafficDetailResultModel:ResponseModel
    {
        public List<UserTrafficDetailResultData> data { get; set; }
    }

    public class UserTrafficDetailResultData
    {
        /// <summary>
        /// 日期
        /// </summary>
        public long flowDate { get; set; }
        /// <summary>
        /// 当日消耗流量设备数
        /// </summary>
        public int deviceCount { get; set; }
        /// <summary>
        /// 当日消耗流量通道数
        /// </summary>
        public int channelCount { get; set; }
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
