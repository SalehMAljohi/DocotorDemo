﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Datum
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}