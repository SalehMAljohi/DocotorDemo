using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Root
    {
        public Meta meta { get; set; }
        public List<Datum> data { get; set; }
    }
}