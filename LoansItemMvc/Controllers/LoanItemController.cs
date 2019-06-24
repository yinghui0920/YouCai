using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.IO;
using System.Web.Mvc;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using LoansItemMvc.ServiceReference2;
using LoansItemMvc.ServiceClient;
using LoansItemMvc.ServiceReference4;


namespace LoansItemMvc.Controllers
{
    public class LoanItemController : Controller
    {
        AddOneClient client = new AddOneClient();
        GetLoginClient getlogin = new GetLoginClient();

        // GET: LoanItem
        //登录、注册
        public ActionResult Login()
        {
            return View();
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int Add(ServiceClient.YCUserInfoData data)
        {
            var result = client.DoWork1(data);
            Session["name"] = data.U_Id;
            return 1;
        }
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int DengLu(ServiceReference4.YCUserInfoData data)
        {
            var result = getlogin.DoWork(data);
            return 1;
        }

        //首页
        public ActionResult Home()
        {
            return View();
        }

        //贷款类型
        public ActionResult Index()
        {
            ServiceReference2.GetClient TClient = new ServiceReference2.GetClient();
            ServiceReference2.YCLoanTypeData n = new ServiceReference2.YCLoanTypeData();
            ServiceReference2.YCLoanTypeData[] result = TClient.DoWorkType(n);
            return View(result.ToList());
        }

        //绑定身份下拉
        public JsonResult ListTable()
        {
            ServiceReference2.GetClient TClient = new ServiceReference2.GetClient();
            ServiceReference2.YCIdentityTableData n = new ServiceReference2.YCIdentityTableData();
            ServiceReference2.YCIdentityTableData[] result = TClient.DoWorkTable(n);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        //绑定用途下拉
        public JsonResult ListGoal()
        {
            ServiceReference2.GetClient TClient = new ServiceReference2.GetClient();
            ServiceReference2.YCloansGoalData n = new ServiceReference2.YCloansGoalData();
            ServiceReference2.YCloansGoalData[] result = TClient.DoWorkGoal(n);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        //计算机
        public ActionResult Calculator()
        {
            return View();
        }

        //显示类型详细信息、登记
        public ActionResult Detail(int id)
        {
            ServiceReference2.GetClient TClient = new ServiceReference2.GetClient();
            ServiceReference2.YCLoanTypeData n = new ServiceReference2.YCLoanTypeData();
            Session["key"] = n.LT_Id = id;
            ServiceReference2.YCLoanTypeData[] result = TClient.DoWorkType(n);
            return View(result.ToList());
        }

        //显示类型详细信息、登记
        public JsonResult Detaila(ServiceReference1.YCUserDetailsData YCUser)
        {
            string path = Server.MapPath("~/images/");

            HttpFileCollectionBase files = Request.Files;
            for (int i = 0; i < files.Count; i++)
            {
                HttpPostedFileBase file = files[i];
                file.SaveAs(path + file.FileName);
                YCUser.Ud_IDCardPic = path + file.FileName;
            }

            ServiceReference1.AddClient TClient = new ServiceReference1.AddClient();
            ServiceReference1.YCUserDetailsData y = new ServiceReference1.YCUserDetailsData();
            bool n = TClient.DoWork(YCUser); //调用WCF中的方法
            if (n == true)
            {
                Response.Write("<script>alert('提交成功');location.href='/LoanItem/Detail'</script>");
            }
            return Json(files.Count + " Files Uploaded!");
        }

        private const String host = "http://dingxin.market.alicloudapi.com";
        private const String path = "/dx/sendSms";
        private const String method = "POST";
        private const String appcode = "7ef435ea1fea453ebfa0fcd3430b51bc";

      

        //获取验证码
            public string MessageType(string tel)
        {
            Random r = new Random();
            var n = r.Next(100000, 999999);
            Session["value"] = n;
            String querys = "mobile=" + tel + "&param=code:" + n + "&tpl_id=TP1711063";
            String bodys = "";
            String url = host + path;
            HttpWebRequest httpRequest = null;
            HttpWebResponse httpResponse = null;

            if (0 < querys.Length)
            {
                url = url + "?" + querys;
            }

            if (host.Contains("https://"))
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                httpRequest = (HttpWebRequest)WebRequest.CreateDefault(new Uri(url));
            }
            else
            {
                httpRequest = (HttpWebRequest)WebRequest.Create(url);
            }
            httpRequest.Method = method;
            httpRequest.Headers.Add("Authorization", "APPCODE " + appcode);
            if (0 < bodys.Length)
            {
                byte[] data = Encoding.UTF8.GetBytes(bodys);
                using (Stream stream = httpRequest.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }
            try
            {
                httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            }
            catch (WebException ex)
            {
                httpResponse = (HttpWebResponse)ex.Response;
            }

            //Console.WriteLine(httpResponse.StatusCode);
            //Console.WriteLine(httpResponse.Method);
            //Console.WriteLine(httpResponse.Headers);
            //Stream st = httpResponse.GetResponseStream();
            //StreamReader reader = new StreamReader(st, Encoding.GetEncoding("utf-8"));
            //Console.WriteLine(reader.ReadToEnd());
            //Console.WriteLine("\n");
            return n.ToString();

        }

        public static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true;
        }
        //个人中心
        public ActionResult MyPersonCenter(UserDetailAndMyBill u)
        {
            u.Ud_Name = "梁旭";
            ServiceReference2.UserDetailAndMyBill userAndBill = new UserDetailAndMyBill();
            ServiceReference2.GetClient client = new GetClient();
            UserDetailAndMyBill s = JsonConvert.DeserializeObject<UserDetailAndMyBill>(client.GetUserInfoAndMyBill(u));
            return View(s);
        }
        //帮助
        public ActionResult Helphelp()
        {
            return View();
        }
    }

}
