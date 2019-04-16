﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alkoshop.Models
{
    public class Product
    {
        public Product(int id, string name, string producer, int pricePU, string availability)
        {
            Id = id;
            Name = name;
            Producer = producer;
            PricePU = pricePU;
            this.availability = availability;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }
        public int PricePU { get; set; }
        public string availability { get; set; }

    }
}