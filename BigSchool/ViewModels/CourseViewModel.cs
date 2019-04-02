using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BigSchool.Models;
using System.ComponentModel.DataAnnotations;

namespace BigSchool.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { set; get; }
        [Required]
        [FutureDate]
        public string Date { set; get; }
        [Required]
        [ValidTime]
        public string Time { set; get; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.ParseExact(string.Format("{0} {1}", Date, Time), "dd/MM/yyyy HH:mm", null);
        }
       
       
        
    }

}