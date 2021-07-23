using MVC_CRUD_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CRUD_Project.DAL
{
    public class ProductRepository
    {
        private ProductContext _dbcontext;

        public ProductRepository(ProductContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public List<Product> GetProducts()
        {
            return _dbcontext.Product.ToList();
        }

        public void CreateProduct(Product product)
        {
            _dbcontext.Product.Add(product);
            _dbcontext.SaveChanges();
        }
        public void EditProduct(Product product)
        {
            _dbcontext.Product.Update(product);
            _dbcontext.SaveChanges();
        }

        public void DeleteProduct(int ProductId)
        {
            var selectedProduct = _dbcontext.Product.Where(i => i.ProductId == ProductId).FirstOrDefault();

            if(selectedProduct!=null)
            {
                _dbcontext.Product.Remove(selectedProduct);
                _dbcontext.SaveChanges();
            }
        }
    }
}
