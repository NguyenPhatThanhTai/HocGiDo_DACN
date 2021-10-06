using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HocGiDo_DACN.Models.JsonModelParse
{
    public class ApiContain
    {
        public String getUrlApi(String apiName)
        {
            var api = "";
            switch (apiName)
            {
                case "course":
                    api = "http://diepquangduc-001-site1.etempurl.com/api/khoahoc";
                    break;
                default:
                    return null;
                    break;
            }
            return api;
        }
    }
}