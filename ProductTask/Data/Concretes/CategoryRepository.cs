using Core.Abstracts;
using Core.Models;
using Data.DataAccessLAyer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concretes
{
    public class CategoryRepository : ICategoryRepository
    {
        AppDbContext _appDbContext = new AppDbContext();
        public void Add(string command)
        {
            _appDbContext.NonQuery(command);
        }

        public void Delete(string command)
        {
            _appDbContext.NonQuery(command);
        }

        public Category Get(string command)
        {
            var dt = _appDbContext.Query(command);
            Category category = null;
            foreach (DataRow item in dt.Rows)
            {
                category = new Category()
                {
                    Id = int.Parse(item[0].ToString()),
                    Name = item[1].ToString(),
                   

                };

            }
            return category;
        }

        public List<Category> GetAll(string command)
        {
            var dt = _appDbContext.Query(command);
            List<Category> categories = new List<Category>(); 
           
            foreach (DataRow item in dt.Rows)
            {
                Category category = new Category()
                {
                    Id = int.Parse(item[0].ToString()),
                    Name = item[1].ToString(),


                };

                categories.Add(category);

            }
            return categories;
        }

        public void Update(string command)
        {
            _appDbContext.NonQuery(command);
        }
    }
}
