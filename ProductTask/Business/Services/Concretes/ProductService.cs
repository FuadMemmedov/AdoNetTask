using Business.Services.Abstracts;
using Core.Abstracts;
using Core.Models;
using Data.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Concretes
{
    public class ProductService : IProductService
    {
        IProductRepository _repository = new ProductRepository();
        public void AddProduct(Product product)
        {
            string command = $"Insert Into Products(Name,Price,CategoryId) Values('{product.Name}', {product.Price},{product.CategoryId} )";
            _repository.Add(command);
        }

        public void DeleteProduct(int id)
        {
            string command = $"Delete From Products where Id = {id}";
            _repository.Delete(command);
        }

        public List<Product> GetAllProduct()
        {
            string command = "Select * From Products";
            return _repository.GetAll(command);
        }

        public Product GetProduct(int id)
        {
            string command = $"Select * From Products where Id = {id}";
            return _repository.Get(command);
        }

        public void UpdateProduct(int id, Product newProduct)
        {
            string command = $"Select * From Products where Id = {id}";
            Product product = _repository.Get(command);

            if (product == null) throw new NullReferenceException();

            product.Name = newProduct.Name;
            product.Price = newProduct.Price;
            product.CategoryId = newProduct.CategoryId;

            string updateCommand = $"Update Products set Name = '{product.Name}', Price = {product.Price}, CategoryId = {product.CategoryId} where Id = {id}";
            _repository.Update(updateCommand);
        }
    }
}
