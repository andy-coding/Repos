using Helpdesk_API_Integration.Helper;
using Helpdesk_API_Integration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Helpdesk_API_Integration.Controllers
{
    public class CategoryController : Controller
    {

        static readonly ICategoryRestClient RestClient = new CategoryRestClient();
        private ICategoryRestClient _restClient;

        public CategoryController()
        {

        }

        public CategoryController(ICategoryRestClient restClient)
        {
            _restClient = restClient;
        }

        // GET: ServerData
        public ActionResult Index()
        {
            return View(RestClient.GetAll());
        }

        // GET: ServerData/Details/5
        public ActionResult DetailCategory(int id)
        {
            return View(RestClient.GetById(1));
        }

        // GET: ServerData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServerData/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ServerData/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ServerData/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ServerData/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ServerData/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
