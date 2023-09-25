using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TatilSeyahatSitesi.Models.Siniflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Value1 { get; set; }
        public IEnumerable<Yorumlar> Value2 { get; set; }
        public IEnumerable<Blog> Value3 { get; set; }
    }
}