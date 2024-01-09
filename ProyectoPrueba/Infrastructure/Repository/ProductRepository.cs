using ProyectoPrueba.Domain;
using ProyectoPrueba.Infrastructure.EntityFramework;

namespace ProyectoPrueba.Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IProductDbContext ProductDbContext;
        public ProductRepository(IProductDbContext productDbContext)
        {
            ProductDbContext = productDbContext;
        }

        public List<Product> GetAll()
        {
            return ProductDbContext.GetAll();
        }
    }
}
