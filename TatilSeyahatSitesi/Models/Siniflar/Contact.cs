using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TatilSeyahatSitesi.Models.Siniflar
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }    
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Comment { get; set; }
           
    }
}