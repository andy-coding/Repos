using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Helpdesk_API_Integration.Models;
using System.Text;
using System.Threading.Tasks;

namespace Helpdesk_API_Integration.Controllers
{
    public class RestClientController : Controller
    {

        public void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message + Environment.NewLine);
            }

        }

        // GET: RestClient
        public ActionResult GetCats()
        {
            RestClient rClient = new RestClient();
            //rClient.endPoint = txtRequestURI.Text;

            debugOutput("Rest client created");

            string strResponse = string.Empty;

            strResponse = rClient.makeRequest();

            debugOutput(strResponse);

            return View();
        }
    }
}