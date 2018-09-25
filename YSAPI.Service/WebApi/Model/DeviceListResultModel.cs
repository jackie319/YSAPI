using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YSAPI.Service.Common;

namespace YSAPI.Service.WebApi.Model
{
    public class DeviceListResultModel : ResponseModel
    {
        public PageModel Page { get; set; }
        public List<DeviceListResultData> Data { get; set; }
    }

    public class DeviceListResultData
    {
        /// <summary>
        /// 设备序列号
        /// </summary>
        public string DeviceSerial { get; set; }
        /// <summary>
        /// 设备名称
        /// </summary>
        public string DeviceName { get; set; }
        /// <summary>
        /// 设备类型
        /// </summary>
        public string DeviceType { get; set; }
        /// <summary>
        /// 在线状态：0-不在线，1-在线
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 具有防护能力的设备布撤防状态：0-睡眠，8-在家，16-外出，普通IPC布撤防状态：0-撤防，1-布防
        /// </summary>
        public string Defence { get; set; }
        /// <summary>
        /// 设备版本号
        /// </summary>
        public string DeviceVersion { get; set; }
    }
}
