using Microsoft.EntityFrameworkCore;
using MVC_CRUD_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CRUD_Project.DAL
{
    public class ProductContext :DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)  :base(options)
        {

        }
        public DbSet<Product> Product { get; set; }
        public DbSet<MVC_CRUD_Project.Models.ProductViewModel> ProductViewModel { get; set; }
    }
}
