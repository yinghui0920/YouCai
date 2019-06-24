using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoansItemMvc.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Photo()
        {
            string path = Server.MapPath("~/images/");

            HttpFileCollectionBase files = Request.Files;
            for (int i = 0; i < files.Count; i++)
            {
                HttpPostedFileBase file = files[i];
                file.SaveAs(path + file.FileName);
                Session["photo"] = path + file.FileName;
            }
            return Json(files.Count + " Files Uploaded!");
        }
        //[HttpPost]
        //public ActionResult UploadFiles()
        //{ string path = Server.MapPath("~/WorkFolder/Upload/Inspection/"); HttpFileCollectionBase files = Request.Files; for (int i = 0; i < files.Count; i++) { HttpPostedFileBase file = files[i]; file.SaveAs(path + file.FileName); } return Json(files.Count + " Files Uploaded!");
        //}
    }
}