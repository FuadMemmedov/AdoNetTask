using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Abstracts
{
    public interface ICategoryService
    {
        void DeleteCategory(int id);
        void AddCategory(Category category);
        void UpdateCategory(int id, Category newCategory);

        Category GetCategory(int id);
        List<Category> GetAllCategories();
    }

}
