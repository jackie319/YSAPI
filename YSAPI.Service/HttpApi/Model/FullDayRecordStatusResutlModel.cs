using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YSAPI.Service.Common;

namespace YSAPI.Service.HttpApi.Model
{
    public class FullDayRecordStatusResutlModel:ResponseModel
    {
        public FullDayRecordStatusResultData data { get; set; }
    }
    public class FullDayRecordStatusResultData
    {
        /// <summary>
        /// 设备序列号
        /// </summary>
        public string deviceSerial { get; set; }
        /// <summary>
        /// 通道号
        /// </summary>
        public string channelNo { get; set; }
        /// <summary>
        /// 状态：0-关闭，1-开启
        /// </summary>
        public string enable { get; set; }
    }
}
