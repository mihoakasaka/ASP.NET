using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VidPlace.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [Required] [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Address { get; set; }

        
       
        public Boolean IsSubscribedToNewsLetter { get; set; }
        public MembershipType  MembershipType{ get; set; }
        public byte MembershipTypeId { get; set; }
        public DateTime? Birthday { get; set; }
        public override string ToString()
        {
            return"Name :"+Name+"|Address :"+Address;
        }
    }
}