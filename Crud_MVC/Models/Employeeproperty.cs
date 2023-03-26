using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Crud_MVC.Models
{
    public class Employeeproperty
    {
        [Key]
        public int Id { get; set; }
        
        public string EMPCODE { get; set; }
        public string EMPNAME { get; set; }
        public string DESTINATION{ get; set; }
        public double SALARY { get; set; }
    }
}