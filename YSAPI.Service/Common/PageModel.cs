using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YSAPI.Service.Common
{
   public  class PageModel
    {
        public string total { get; set; }
        /// <summary>
        /// 分页起始页，从0开始
        /// </summary>
        public string page { get; set; }

        public string size { get; set; }
    }
}
