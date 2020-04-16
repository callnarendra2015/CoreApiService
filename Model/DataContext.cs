using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CoreApiService.Model
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Products> Products { get; set; }



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=NAREN-PC; Database=CoreApiServiceDB3; Trusted_Connection=True; MultipleActiveResultSets=True;");
        //    //Server = NAREN - PC; Database = CoreApiServiceDB3; Trusted_Connection = True; MultipleActiveResultSets = True;
        //    //server=NAREN-PC;userid=sa;password=sa123;database=CoreApiServiceDB;
        //}

    }
      

}
