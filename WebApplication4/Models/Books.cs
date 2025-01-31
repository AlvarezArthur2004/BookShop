using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Books
    {
        public int id { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public string discription { get; set; }
        public string company { get; set; }
        public string source { get; set; }
        public double price { get; set; }
        public double rate { get; set; }
        public int year { get; set; }
        public int purhases { get; set; }
        public int pages { get; set; }
        public long ISBN { get; set; }
        public int tax { get; set; }
    }
}