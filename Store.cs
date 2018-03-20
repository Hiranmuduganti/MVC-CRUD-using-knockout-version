using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;


namespace mvcapplication.Models
{
    public class Store

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}