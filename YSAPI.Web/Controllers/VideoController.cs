using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using YSAPI.Service;

namespace YSAPI.Web.Controllers
{
    public class VideoController : Controller
    {
        private string accessToken = "at.c27cb2dxau6odzj24kyom9jb3gjnnhc3-45f70uy0b5-1dnwfw0-6ekpviujh";
        // GET: Video
        public ActionResult Index(string hls,string rtmp)
        {
            ViewBag.hls = hls;
            ViewBag.rtmp = rtmp;
            return View();
        }
        /// <summary>
        /// 视频列表
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult> List()
        {
            var result = await YSAPIManager.GetVideoList(accessToken, 0, 50);
            return View(result.data);
        }
    }
}