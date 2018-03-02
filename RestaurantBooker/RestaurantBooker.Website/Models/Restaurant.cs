using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantBooker.Website.Models
{
    public class Restaurant
    {
        public string Name { get; set; }
        public List<Table> Tables { get; set; }
    }
}