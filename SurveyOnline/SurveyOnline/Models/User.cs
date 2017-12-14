using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SurveyOnline.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required]
        [StringLength(255)]
        public string FName{get;set;}
        [Required]
        [StringLength(255)]
        public string LName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string AnnualIncome { get; set; }
        
        public string Survey { get; set; }
        [Required]
        public byte SurveyId { get; set; }

        [Required]
        public string SurveyAnswer { get; set; }
    }
}