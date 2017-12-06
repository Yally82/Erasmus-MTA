
using System.Web.Mvc;
using Erasmus_MTA.Models;
using System.Collections.Specialized;
using Erasmus_MTA.Utilities;

namespace Erasmus_MTA.Controllers
{
    public class HomeController : Controller
    {
        private ErasmusEntities database = new ErasmusEntities();

        public ActionResult Index()
        {
            string logout = HttpContext.Request.Params.Get("logout");

            if(logout != null)
            {
                if(logout.CompareTo("logout") == 0)
                {
                    this.logout();
                }
            }

            return View();
        }

        public void logout()
        {
            Session.Clear();
            Session.Abandon();
        }

        public ActionResult login()
        {
            NameValueCollection nvc = Request.Form;
            string username = null;
            string password = null ;

            if (!string.IsNullOrEmpty(nvc["username"]))
            {
                username = nvc["username"];
            }

            if (!string.IsNullOrEmpty(nvc["passwordHash"]))
            {
                //Calculate hash
                password = nvc["passwordHash"];
                string hash = HashGenerator.getHash(password);

                //compare with hash in database
                foreach (LoginUser x in database.LoginUsers)
                {
                    if (x.Username.CompareTo(username) == 0)
                    {
                        if (hash.CompareTo(x.PasswordHash)==0)
                        {
                            Session["Username"] = x.Name;
                            return View("~/Views/Mobilities/Index.cshtml");
                        }
                    }
                }
            }

            return View("~/Views/Home/Index.cshtml");
        }
    }
}