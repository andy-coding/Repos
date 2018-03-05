using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Helpdesk_API_Integration.Models;
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

            //_repository = new CategoryRepository;
        }

        public ActionResult Cats()
        {
            //var client = new RestClient("http://localhost:9075/api/");
            //RestRequest request = new RestRequest("category", Method.GET);
            //IRestResponse<List<category>> response = client.Execute<List<category>>(request);

            return View();
        }

        // GET api/products
        public IEnumerable<category> Get()
        {
            return _repository.GetAll();
        }

        // GET api/products/5
        public category Get(int id)
        {
            return _repository.Get(id);
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
    }
}

