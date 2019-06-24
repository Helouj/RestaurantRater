using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantRaterMVC.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }

        public string FoodType { get; set; }
    }
}