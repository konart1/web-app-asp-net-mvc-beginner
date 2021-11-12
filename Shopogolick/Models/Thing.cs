using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Shop.Models
{
    public class Thing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }

        public string Size { get; set; }

        public string Color { get; set; }

        public string Descripton { get; set; }

        public int Price { get; set; }
    }
}