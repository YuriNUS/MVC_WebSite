using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace LogicUniversity__AD_T4.Controllers
{
    public class DepartmentHeadController : Controller
    {
        static string uri = "http://192.168.1.182/MyApi/api/";

        // GET: DepartmentHead
        public async Task<ActionResult> Home()
        {
//            string myString = "";
//            using (HttpClient httpClient = new HttpClient())
//            {
//                uri = uri + '/' + "Requitition" +'/'+ "getall";
//
//                myString = await httpClient.GetStringAsync(uri);
//
//            }
            
            return  View();
        }
    }
}