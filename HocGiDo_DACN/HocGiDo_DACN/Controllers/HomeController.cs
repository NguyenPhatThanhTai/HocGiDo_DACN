﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using HocGiDo_DACN.Models;

namespace HocGiDo_DACN.Controllers
{
    public class HomeController : Controller
    {
        private static readonly HttpClient client = new HttpClient();
        public async Task<ActionResult> Index()
        {
            var responseString = await client.GetStringAsync("https://api.covid19api.com/countries");
            var objResponse1 = JsonConvert.DeserializeObject<List<test>>(responseString);
            //var result = JsonConvert.DeserializeObject<test>(responseString);
            ViewBag.res = objResponse1;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}