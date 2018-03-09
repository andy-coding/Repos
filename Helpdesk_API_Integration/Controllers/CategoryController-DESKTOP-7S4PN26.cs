using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Helpdesk_API_Integration.Models;
using Newtonsoft.Json;
using RestSharp;

namespace Helpdesk_API_Integration.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ICategoryRepository _repository;

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

        public CategoryController()
        {
            var response2 = new RestResponse<category>();


        }


        public async Task<ActionResult> GetCategoriesOld()
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


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<category> ListCategories()
        {
            var client = new RestSharp.RestClient("http://itildemo.servicedeskplus.com/");

            var request = new RestRequest("sdpapi/admin/category", Method.GET) { RequestFormat = DataFormat.Json }; ;
            request.AddParameter("OPERATION_NAME", "GET_ALL");
            request.AddParameter("TECHNICIAN_KEY", "D86DF679-FE1F-44ED-9156-D69E1EBF8FAD");

            var response = client.Execute<List<category>>(request);

            if (response.Data == null)
                throw new Exception(response.ErrorMessage);

            debugOutput(request.Parameters.ToString());


           // var response2 = client.Execute<category>(request);
            //var name = response2.Data.NAME.ToString();

            //debugOutput(response.StatusCode.ToString());
            //var response = new List<category> { new category { ID = 1, NAME = "bob", ISDELETED = false } };


            //try
            //{
            //    System.Diagnostics.Debug.Write(queryResult.ToString() + Environment.NewLine);
            //}
            //catch (Exception ex)
            //{
            //    System.Diagnostics.Debug.Write(ex.Message + Environment.NewLine);
            //}

            //debugOutput(mycat.ToString());


            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult DetailCategory()
        {

            var client = new RestSharp.RestClient("http://itildemo.servicedeskplus.com");

            var request = new RestRequest("sdpapi/admin/category/2", Method.GET) { RequestFormat = DataFormat.Json };
            request.AddParameter("OPERATION_NAME", "GET");
            request.AddParameter("TECHNICIAN_KEY", "D86DF679-FE1F-44ED-9156-D69E1EBF8FAD");
            debugOutput(request.Parameters.ToString());

            var queryResult = client.Execute<category>(request).Data;
            //var queryResult = new category { ID = 1, NAME = "bob", ISDELETED = false };

            return View(queryResult);
        }



        //// PUT api/products/5
        //public void Put(int id, [FromBody]category value)
        //{
        //    _repository.Update(id, value);
        //}

        // DELETE api/products/5
        //public void Delete(int id)
        //{
        //    _repository.Delete(id);
        //}

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

        //    //request.AddUrlSegment("id", "123"); // replaces matching token in request.Resource

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
    }
}

