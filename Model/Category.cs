using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CoreApiService.Model
{
    public class Category
    {
        [Key]
        public int Categoryid { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public int Name { get; set; }
        public Boolean? IsActive { get; set; }

    }
}
