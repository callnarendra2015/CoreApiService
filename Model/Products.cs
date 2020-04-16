using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Threading.Tasks;

namespace CoreApiService.Model
{
    public class Products
    {
        [Key]
        public int Productid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal UnitPrice { get; set; }
        public DateTime? DateOfRegistration { get; set; }
        public int Categoryid { get; set; }

        // support lazyloading 
        public virtual Category category { get; set; }

    }
}
