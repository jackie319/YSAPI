using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YSAPI.Service.AccessToken
{
    public  class GetTokenRequestModel
    {
        public string appKey { get; set; }
        public string appSecret { get; set; }
    }
}
