using Business.Services.Abstracts;
using Business.Services.Concretes;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTask.Controllers
{
    public class ProductController
    {
        IProductService _productService = new ProductService();
        public void AddProduct() 
        {
            Console.Write("Enter product Name: ");
            string name = Console.ReadLine();

            
            decimal price;
            int categoryId;
             
            do
            {
                Console.Write("Enter product Price: ");

            } while (!decimal.TryParse(Console.ReadLine(),out price));

            do
            {
                Console.Write("Enter categoryId: ");


            } while (!int.TryParse(Console.ReadLine(),out categoryId));

            Product product = new Product()
            {
                Name = name,
                Price = price,
                CategoryId = categoryId

            };

            _productService.AddProduct(product);

        
        
        
        }
        public void DeleteProduct()
        {
            int id;
            do
            {
                Console.Write("Enter id: ");

            } while (!int.TryParse(Console.ReadLine(),out id));

            _productService.DeleteProduct(id);
        }

        public void UpdateProduct()
        {
            int id;
            do
            {
                Console.Write("Enter id: ");

            } while (!int.TryParse(Console.ReadLine(), out id));
            Console.Write("Enter product Name: ");
            string name = Console.ReadLine();


            decimal price;
            int categoryId;

            do
            {
                Console.Write("Enter product Price: ");

            } while (!decimal.TryParse(Console.ReadLine(), out price));

            do
            {
                Console.Write("Enter categoryId: ");


            } while (!int.TryParse(Console.ReadLine(), out categoryId));

            Product newproduct = new Product()
            {
                Name = name,
                Price = price,
                CategoryId = categoryId

            };
            _productService.UpdateProduct(id,newproduct);

        }
        public void ShowAllProduct()
        {
            foreach (var item in _productService.GetAllProduct())
            {
                Console.WriteLine($"Id: {item.Id} Name: {item.Name} Price: {item.Price} CategoryId: {item.CategoryId} ");

            }
        }

        public void Get()
        {
            int id;
            do
            {
                Console.Write("Enter id: ");

            } while (!int.TryParse(Console.ReadLine(), out id));

           Product product = _productService.GetProduct(id);

            Console.WriteLine($"Id: {product.Id} Name: {product.Name} Price: {product.Price} CategoryId: {product.CategoryId} ");

        }
    }
}
