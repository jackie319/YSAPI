using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YSAPI.Service.Common;

namespace YSAPI.Service.WebApi.Model
{
    public class CameraListResultModel:ResponseModel
    {
        public PageModel Page { get; set; }
        public List<CameraListResultData> Data { get; set; }
    }

    public class CameraListResultData
    {
        public string DeviceSerial { get; set; }
        public string ChannelNo { get; set; }
        public string ChannelName { get; set; }
        /// <summary>
        /// 	在线状态：0-不在线，1-在线
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// 分享状态：1-分享所有者，0-未分享，2-分享接受者（表示此摄像头是别人分享给我的）
        /// </summary>
        public string IsShared { get; set; }
        /// <summary>
        /// 图片地址（大图），若在萤石客户端设置封面则返回封面图片，未设置则返回默认图片
        /// </summary>
        public string PicUrl { get; set; }
        /// <summary>
        /// 是否加密，0：不加密，1：加密
        /// </summary>
        public string IsEncrypt { get; set; }
        /// <summary>
        /// 视频质量：0-流畅，1-均衡，2-高清，3-超清
        /// </summary>
        public string VideoLevel { get; set; }
    }
}
