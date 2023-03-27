using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Lab.Net.MVC.Models.RickView;

namespace Lab.Net.MVC.Models
{
    public class ResponseRick
    {
        public RickApiInfo info { get; set; }
        public List<RickView> results { get; set; }
    }

    public class RickApiInfo
    {
        public int count { get; set; }
        public int pages { get; set; }
        public string next { get; set; }
        public string prev { get; set; }
    }
}