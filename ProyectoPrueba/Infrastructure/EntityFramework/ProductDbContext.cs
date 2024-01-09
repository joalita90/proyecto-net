using Microsoft.EntityFrameworkCore;
using ProyectoPrueba.Domain;

namespace ProyectoPrueba.Infrastructure.EntityFramework
{
    public class ProductDbContext: DbContext, IProductDbContext
    {
        public DbSet<Product> Products { get; set; }

        public List<Product> GetAll()
        {
            //return this.Products.ToList();
            return new List<Product>()
            {
                new() { Id = 1, Name = "Manzana"},
                new() { Id = 2, Name = "Piano"}
            };
        }
    }
}
