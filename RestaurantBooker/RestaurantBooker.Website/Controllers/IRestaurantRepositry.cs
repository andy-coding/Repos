using RestaurantBooker.Website.Models;
using System.Collections.Generic;

namespace RestaurantBooker.Website.Controllers
{
    public interface IRestaurantRepositry
    {
        IEnumerable<Restaurant> GetAll();
    }
}