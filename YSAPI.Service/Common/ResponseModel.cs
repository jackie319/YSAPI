using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YSAPI.Service.Common
{
    public class ResponseModel
    {
        /// <summary>
        /// 返回码
        /// </summary>
        public string code { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string msg { get; set; }
    }
}
