using HocGiDo_DACN.Models.JsonModelParse;
using HocGiDo_DACN.Models.JsonModelParse.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HocGiDo_DACN.Controllers
{
    public class UserController : Controller
    {
        ParseJson parseJson;
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> TrangChu()
        {
            parseJson = new ParseJson();
            Course course = await parseJson.GetCourse();
            if(course != null)
            {
                return View(course);
            }
            else
            {
                Response.StatusCode = 404;
                return View();
            }
        }
    }
}