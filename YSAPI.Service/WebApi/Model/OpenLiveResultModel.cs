using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YSAPI.Service.Common;

namespace YSAPI.Service.WebApi.Model
{
    public class OpenLiveResultModel:ResponseModel
    {
        public List<OpenLiveResultData> data { get; set; }
    }

    public class OpenLiveResultData
    {
        /// <summary>
        /// 设备序列号
        /// </summary>
        public string deviceSerial { get; set; }
        /// <summary>
        /// 通道号
        /// </summary>
        public int channelNo { get; set; }
        /// <summary>
        /// 设备开通状态码，参考下方返回码
        /// </summary>
        public string ret { get; set; }
        /// <summary>
        /// 设备开通状态描述
        /// </summary>
        public string desc { get; set; }
    }
}
