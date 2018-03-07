﻿using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant {Id=1, Name = "Andrew's Dogs and Beef" },
                new Restaurant {Id=2, Name = "Hanlong Chicken and Chicken"},
                new Restaurant {Id=3, Name = "Andrew and Songs Pizza Palace"}
            };
        }
        
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }

        List<Restaurant> _restaurants;
    }
}