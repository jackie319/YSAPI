using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using YSAPI.Service.Common;

namespace YSAPI.Service
{
    internal static class RequestUtility
    {
        /// <summary>
        /// POST请求
        /// </summary>
        /// <param name="data">请求对象</param>
        /// <param name="url">请求地址</param>
        /// <returns></returns>
        public static async Task<string> PostAsync(string data, string url)
        {
            using (var webClient = new WebClient { Encoding = Encoding.UTF8 })
            {
                webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                var result = await webClient.UploadStringTaskAsync(url, "POST", data);
                return result;
            }
        }

        /// <summary>
        /// POST请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <param name="model"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static async Task<T1> PostAsync<T, T1>(T model, string url)
        {
            using (var webClient = new WebClient { Encoding = Encoding.UTF8 })
            {
                string data = GetRequestString<T>(model);
                webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                var result = await webClient.UploadStringTaskAsync(url, "POST", data);
                var resultModel = JsonConvert.DeserializeObject<T1>(result);
                return resultModel;
            }
        }

        /// <summary>
        /// POST请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static async Task<T> PostAsync<T>(string data, string url)
        {
            using (var webClient = new WebClient { Encoding = Encoding.UTF8 })
            {
                webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                var result = await webClient.UploadStringTaskAsync(url, "POST", data);
                var resultModel = JsonConvert.DeserializeObject<T>(result);
                return resultModel;
            }
        }

        public static T Post<T>(string data, string url)
        {
            using (var webClient = new WebClient { Encoding = Encoding.UTF8 })
            {
                webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                var result = webClient.UploadString(url, "POST", data);
                var resultModel = JsonConvert.DeserializeObject<T>(result);
                return resultModel;
            }
        }

        /// <summary>
        /// 拼接请求数据
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="model">对象</param>
        private static string GetRequestString<T>(T model)
        {
            var data = string.Empty;
            Type t = model.GetType();
            PropertyInfo[] propertyList = t.GetProperties();
            for (int i = 0; i < propertyList.Count(); i++)
            {
                string name = propertyList[i].Name;
                object value = propertyList[i].GetValue(model, null);
                data += i == propertyList.Count() - 1 ? $"{name}={value}" : $"{name}={value}&";
            }
            return data;
        }

        /// <summary>
        /// 拼接批量请求数据
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        internal static string GetRequestData(List<SourceModel> list)
        {
            string result = string.Empty;
            for (int i = 0; i < list.Count; i++)
            {

                result += i == list.Count - 1 ? $"{list[i].deviceSerial}:{list[i].channelNo}" : $"{list[i].deviceSerial}:{list[i].channelNo},";
            }
            return result;
        }
    }
}
