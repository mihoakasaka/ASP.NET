using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Phono.Models
{
    public class Phone
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Brand Brand { get; set; }
        public byte BrandId { get; set; }
        public string ScreenSize { get; set; }
        public PhoneType PhoneType { get; set; }
        public byte PhoneTypeId { get; set; }

    }
}