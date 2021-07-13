using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RSETserver1.Models
{
    public class Customer
    {
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Range(minimum:18,maximum:90)]       
        public int age { get; set; }
        [Remote("CheckUserId", "Customer", "ID has been used before")]
       
        public int id { get; set; }

      

    }
}