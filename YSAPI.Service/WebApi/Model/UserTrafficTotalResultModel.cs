using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YSAPI.Service.Common;

namespace YSAPI.Service.WebApi.Model
{
  public  class UserTrafficTotalResultModel:ResponseModel
    {
        public UserTrafficTotalResultData data { get; set; }
    }

    public class UserTrafficTotalResultData
    {
        /// <summary>
        /// 拥有的总流量，单位字节
        /// </summary>
        public long totalFlow { get; set; }
        /// <summary>
        /// 已使用的流量，单位字节
        /// </summary>
        public long usedFlow { get; set; }
        /// <summary>
        /// 日平均消耗，单位字节/天
        /// </summary>
        public long averageConsume { get; set; }
    }
}
