using Helpdesk_API_Integration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace Helpdesk_API_Integration.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult IndexNew()
        {
            return View();
        }

        public ActionResult NewRequest()
        {
            return View();
        }


        public async Task<ActionResult> GetCategories()
        {
            //Hosted web API REST Service base url  
            string Baseurl = "http://itildemo.servicedeskplus.com/";

            List<category> Categories = new List<category>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("demo", "16AFE541-ED6C-41A6-BCF1-8FB4BDA8F3DA");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("sdpapi/admin/category?OPERATION_NAME=GET_ALL");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var CategoryResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    Categories = JsonConvert.DeserializeObject<List<category>>(CategoryResponse);

                }
            }
            return View(Categories);
        }

        //public ActionResult Categories()

        ////NOTE this used for reference: http://dkdevelopment.net/2010/05/18/dropbox-api-and-restsharp-for-a-c-developer/
        //{
        //    ViewBag.Title = "Categories";

        //    var client = new RestClient("http://itildemo.servicedeskplus.com");
        //    var _apiKey = "16AFE541-ED6C-41A6-BCF1-8FB4BDA8F3DA";

        //    // client.Authenticator = new HttpBasicAuthenticator(username, password);

        //    var request = new RestRequest("sdpapi/admin/category/", Method.GET);
        //    request.AddParameter("demo", "16AFE541-ED6C-41A6-BCF1-8FB4BDA8F3DA"); // adds to POST or URL querystring based on Method
        //    request.AddParameter("oauth_consumer_key", _apiKey);




        //    //var queryResult = client.Execute<List<category>>(request).Data;

        //    request.AddParameter("demo", "16AFE541-ED6C-41A6-BCF1-8FB4BDA8F3DA"); // adds to POST or URL querystring based on Method

        //    //test result to debug
        //    var queryResult = new List<category>
        //    {
        //        new category
        //        {
        //            ID=1,
        //            NAME="cat1",
        //            ISDELETED = false
        //        }
        //    };


        //    //request.AddUrlSegment("id", "123"); // replaces matching token in request.Resource

        //    // easily add HTTP Headers
        //    request.AddHeader("demo", "16AFE541-ED6C-41A6-BCF1-8FB4BDA8F3DA");

        //    // add files to upload (works with compatible verbs)
        //    //request.AddFile(path);

        //    // execute the request
        //    IRestResponse response = client.Execute(request);
        //    var content = response.Content; // raw content as string

        //    // or automatically deserialize result
        //    // return content type is sniffed but can be explicitly set via RestClient.AddHandler();
        //    //IRestResponse<category> response2 = client.Execute<category>(request);
        //    //var name = response2.Data.NAME;

        //    //// easy async support
        //    //client.ExecuteAsync(request, response => {
        //    //    Console.WriteLine(response.Content);
        //    //});

        //    // async with deserialization
        //    //var asyncHandle = client.ExecuteAsync<category>(request, response => {
        //    //    Console.WriteLine(response.Data.NAME);
        //    //});

        //    //// abort the request on demand
        //    //asyncHandle.Abort();

        //    return View();
        //}


        // GET: SundayMVC
        public ActionResult IndexNew3()
        {
            var client = new RestSharp.RestClient("http://itildemo.servicedeskplus.com");
            //client.Authenticator = new SimpleAuthenticator("username", "demo", "Apikey", "F98A31E4-5C0D-40E3-B5CC-B4B721438476");
            var request = new RestRequest("sdpapi/admin/category", Method.GET);
            request.AddParameter("OPERATION_NAME", "GET_ALL");
            request.AddParameter("TECHNICIAN_KEY", "A8321E89-6A8A-4C0E-97E0-C21E5CE4ECE9");
            var response = client.Execute<List<category>>(request).Data;

            //debugOutput(response.StatusCode.ToString());
            //var queryResult = new List<category> { new category { ID = 1, NAME = "bob", ISDELETED = false } };
            
            
            //try
            //{
            //    System.Diagnostics.Debug.Write(queryResult.ToString() + Environment.NewLine);
            //}
            //catch (Exception ex)
            //{
            //    System.Diagnostics.Debug.Write(ex.Message + Environment.NewLine);
            //}

            //debugOutput(mycat.ToString());


            return View(response);
        }

        // GET: SundayMVC/Details/5
        public ActionResult Details()
        {

            var client = new RestSharp.RestClient("http://itildemo.servicedeskplus.com");
            //client.Authenticator = new SimpleAuthenticator("username", "demo", "Apikey", "F98A31E4-5C0D-40E3-B5CC-B4B721438476");
            var request = new RestRequest("sdpapi/admin/category/1", Method.GET);
            request.AddParameter("OPERATION_NAME", "GET");
            request.AddParameter("TECHNICIAN_KEY", "A8321E89-6A8A-4C0E-97E0-C21E5CE4ECE9");
            var queryResult = client.Execute<category>(request).Data;
            //var queryResult = new category { ID = 1, NAME = "bob", ISDELETED = false };

            return View(queryResult);
        }

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
    }
}