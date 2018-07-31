using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Customer
    {
        [Key]
        public int Customer_ID { get; set; }
        public string SongName { get; set; }
        public string Artist { get; set; }
        public string RequestedBy { get; set; }
 
    }
}