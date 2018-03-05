using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestSharp;
using Helpdesk_API_Integration.Models;

namespace Helpdesk_API_Integration.Controllers
{
    public class SundayMVCController : Controller
    {
        // GET: SundayMVC
        public ActionResult SundayMVCControllerGet()
        {
            var client = new RestSharp.RestClient("http://itildemo.servicedeskplus.com");
            var request = new RestRequest("sdpapi/admin/category?OPERATION_NAME=GET_ALL", Method.GET);
            var queryResult = client.Execute<List<category>>(request).Data;

            return View();
        }

        // GET: SundayMVC/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SundayMVC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SundayMVC/Create
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

        // GET: SundayMVC/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SundayMVC/Edit/5
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

        // GET: SundayMVC/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SundayMVC/Delete/5
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
