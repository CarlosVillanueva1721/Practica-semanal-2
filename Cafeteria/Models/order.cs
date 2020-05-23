using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cafeteria.Models
{
    public class order
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public int productname { get; set; }
        [ForeignKey("productname")]
        public Products products { get; set; }
        public int quantity { get; set; }
        public decimal total { get; set; }

        public string Status { get; set; }

        public string Coment { get; set; }

    }
}