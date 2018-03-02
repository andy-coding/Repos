using RestaurantBooker.Website.Controllers;
using RestaurantBooker.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantBooker.Website.ViewModels
{
    public class RestaurantViewModel
    {
        IRestaurantRepositry restaurantRepo;


        public RestaurantViewModel()
        {
            restaurantRepo = new MockRestaurantRepositry();
            Restaurants = restaurantRepo.GetAll();
            AvailableRestaurants = Restaurants.Count();
        }

        public IEnumerable<Restaurant> Restaurants {get;set;}
        int AvailableRestaurants { get; set; }
    }
}