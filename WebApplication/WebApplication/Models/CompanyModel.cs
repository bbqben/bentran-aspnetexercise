using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class CompanyModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public int NumberOfEmployees { get; set; }
    }
}