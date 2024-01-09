using ProyectoPrueba.Domain;

namespace ProyectoPrueba.Services
{
    public abstract class AbstractFactoryProduct
    {
        public abstract Product CreateProduct(Product product);
    }
}
