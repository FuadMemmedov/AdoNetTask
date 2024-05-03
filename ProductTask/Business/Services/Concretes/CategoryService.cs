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
    public class CategoryService:ICategoryService
    {
        ICategoryRepository _repository = new CategoryRepository();
        public void AddCategory(Category category)
        {
            string command = $"Insert Into Categories(Name) Values('{category.Name}' )";
            _repository.Add(command);
        }

        public void DeleteCategory(int id)
        {
            string command = $"Delete From Categories where Id = {id}";
            _repository.Delete(command);
        }

        public List<Category> GetAllCategories()
        {
            string command = "Select * From Categories";
            return _repository.GetAll(command);
        }

        public  Category GetCategory(int id)
        {
            string command = $"Select * From Categories where Id = {id}";
            return _repository.Get(command);
        }

        public void UpdateCategory(int id, Category newCategory)
        {
            string command = $"Select * From Categories where Id = {id}";
            Category category = _repository.Get(command);

            if (category == null) throw new NullReferenceException();

            category.Name = newCategory.Name;
        

            string updateCommand = $"Update Categories set Name = '{category.Name}' where Id = {id}";
            _repository.Update(updateCommand);
        }
    }
}
