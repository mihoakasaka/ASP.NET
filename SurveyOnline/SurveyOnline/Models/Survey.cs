using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace SurveyOnline.Models
{
    public class Survey
    {
        public int ID { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        
        public string SurveyQuestion { get; set; }
        
        public Topic Topic { get; set; }
        [Required]
        public byte TopicId { get; set; }

        [StringLength(255)]
        public string Autohor { get; set; }
        public DateTime? Deadline { get; set; }
    }
}