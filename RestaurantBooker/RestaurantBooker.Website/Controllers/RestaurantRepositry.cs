using RestaurantBooker.Website.Models;
using System;
using System.Collections.Generic;

namespace RestaurantBooker.Website.Controllers
{
    public class MockRestaurantRepositry : IRestaurantRepositry
    {
        public IEnumerable<Restaurant>  GetAll()
        {
            return new List<Restaurant>()
            {
                new Restaurant()
                {
                    Name = "test1"
                }
            };
        }
    }

    public class DBRestaurantRepositry : IRestaurantRepositry
    {
        public IEnumerable<Restaurant> GetAll()
        {
            return new List<Restaurant>();
        }
    }
}