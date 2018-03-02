using RestaurantBooker.Website.Models;
using RestaurantBooker.Website.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantBooker.Website.Controllers
{
    public class RestaurantsController : Controller
    {
        public RestaurantsController()
        {
            restaurantRepo = new MockRestaurantRepositry();
        }

        IRestaurantRepositry restaurantRepo;
        // GET: Restaurants
        public ActionResult Index()
        {

            var model = new RestaurantViewModel();
            return View(model);
        }
    }
}