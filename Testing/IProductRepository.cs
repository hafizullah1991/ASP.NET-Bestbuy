using System.Collections;
using System.Collections.Generic;

using Testing.Models;

namespace Testing
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProdcuts();
      

        public Product GetProduct(int id);
        void UpdateProduct(Product product);

        public void InsertProduct(Product productToInsert);
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();
        public void DeleteProduct(Product product);
    }
}
