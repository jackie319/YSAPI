using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YSAPI.Service.Common;

namespace YSAPI.Service.HttpApi.Model
{
    public class CaptureDeviceResultModel:ResponseModel
    {
        public CaptureDeviceResultData data { get; set; }
    }

    public class CaptureDeviceResultData
    {
        /// <summary>
        /// 抓拍后的图片路径，图片保存有效期为2小时
        /// </summary>
        public string picUrl { get; set; }
    }
}
