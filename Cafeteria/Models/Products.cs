using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace Cafeteria.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string kindpruduct { get; set; }
        public string productname { get; set; }
        public string size { get; set; }
        public decimal price { get; set; }
        public byte[] imagen { get; set; }
    }
}