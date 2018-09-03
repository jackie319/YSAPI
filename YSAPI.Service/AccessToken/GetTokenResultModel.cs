using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YSAPI.Service.Common;

namespace YSAPI.Service
{
    public class GetTokenResponseModel: ResponseModel
    {
      
        public AccessTokenModel data { get; set; }
    }

    public class AccessTokenModel
    {
        /// <summary>
        /// 获取的accessToken
        /// </summary>
        public string accessToken { get; set; }
        /// <summary>
        /// 具体过期时间，精确到毫秒
        /// </summary>
        public long expireTime { get; set; }
    }
}
