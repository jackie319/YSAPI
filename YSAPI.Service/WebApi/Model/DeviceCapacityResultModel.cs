using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YSAPI.Service.Common;

namespace YSAPI.Service.WebApi.Model
{
    public class DeviceCapacityResultModel : ResponseModel
    {
        public DeviceCapacityResultData Data { get; set; }
    }
    public class DeviceCapacityResultData
    {
        /// <summary>
        /// 该设备型号是否支持云存储
        /// </summary>
        public string support_cloud { get; set; }
        public string support_intelligent_track { get; set; }
        public string support_p2p_mode { get; set; }
        public string support_resolution { get; set; }
        /// <summary>
        /// 是否支持对讲
        /// </summary>
        public string support_talk { get; set; }
        public string support_wifi_userId { get; set; }
        public string support_remote_auth_randcode { get; set; }
        /// <summary>
        /// 是否支持设备升级
        /// </summary>
        public string support_upgrade { get; set; }
        public string support_smart_wifi { get; set; }
        public string support_ssl { get; set; }
        public string support_weixin { get; set; }
        public string ptz_close_scene { get; set; }
        public string support_preset_alarm { get; set; }
        public string support_related_device { get; set; }
        public string support_message { get; set; }
        public string ptz_preset { get; set; }
        public string support_wifi { get; set; }
        public string support_cloud_version { get; set; }
        public string ptz_center_mirror { get; set; }
        public string support_defence { get; set; }
        public string ptz_top_bottom { get; set; }
        public string support_fullscreen_ptz { get; set; }
        public string support_defenceplan { get; set; }
        public string support_disk { get; set; }
        public string support_alarm_voice { get; set; }
        public string ptz_left_right { get; set; }
        public string support_modify_pwd { get; set; }
        /// <summary>
        /// 是否支持封面抓图: 0-不支持, 1-支持
        /// </summary>
        public string support_capture { get; set; }
        /// <summary>
        /// NVR/R1是否支持关联IPC存储: 0-不支持, 1-支持
        /// </summary>
        public string support_related_storage { get; set; }
        /// <summary>
        /// 是否支持客流统计 0-不支持, 1-支持
        /// </summary>
        public string support_flow_statistics { get; set; }
        public string support_privacy { get; set; }
        public string support_encrypt { get; set; }
        public string support_auto_offline { get; set; }
    }
}
