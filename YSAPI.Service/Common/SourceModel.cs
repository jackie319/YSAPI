using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YSAPI.Service.Common
{
    public class SourceModel
    {
        /// <summary>
        /// 设备号
        /// </summary>
        public string deviceSerial { get; set; }
        /// <summary>
        /// 通道号
        /// </summary>
        public int channelNo { get; set; }
    }
}
