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
    public class CategoryController
    {
        ICategoryService _categoryService = new CategoryService();

        public void AddCategory()
        {
            Console.Write("Enter category Name: ");
            string name = Console.ReadLine();




            Category category = new Category()
            {
                Name = name,

            };

            _categoryService.AddCategory(category);




        }
        public void DeleteCategory()
        {
            int id;
            do
            {
                Console.Write("Enter id: ");

            } while (!int.TryParse(Console.ReadLine(), out id));

            _categoryService.DeleteCategory(id);
        }

        public void UpdateCategory()
        {
            int id;
            do
            {
                Console.Write("Enter id: ");

            } while (!int.TryParse(Console.ReadLine(), out id));
            Console.Write("Enter category Name: ");
            string name = Console.ReadLine();



            Category newCategory = new Category()
            {
                Name = name,


            };
            _categoryService.UpdateCategory(id, newCategory);

        }
        public void ShowAllCategory()
        {
            foreach (var item in _categoryService.GetAllCategories())
            {
                Console.WriteLine($"Id: {item.Id} Name: {item.Name}");

            }
        }

        public void Get()
        {
            int id;
            do
            {
                Console.Write("Enter id: ");

            } while (!int.TryParse(Console.ReadLine(), out id));

            Category category = _categoryService.GetCategory(id);

            Console.WriteLine($"Id: {category.Id} Name: {category.Name}");

        }
    }
}
