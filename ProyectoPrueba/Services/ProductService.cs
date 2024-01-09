using ProyectoPrueba.Domain;

namespace ProyectoPrueba.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository ProductRepository;
        private readonly ISenderProduct SenderProduct;
        
        public ProductService(IProductRepository productRepository, ISenderProduct senderProduct)
        {
            ProductRepository = productRepository;
            SenderProduct = senderProduct;
        }
        public List<Product> GetProducts()
        {
            return ProductRepository.GetAll();
        }

        public void SendProductClients()
        {
            var products = GetProducts();

            foreach (var product in products) 
            {
                SenderProduct.SendProduct(product);
            }
        }
    }
}
