using ProyectoPrueba.Domain;

namespace ProyectoPrueba.Infrastructure.EntityFramework
{
    public interface IProductDbContext
    {
        public List<Product> GetAll();
    }
}
