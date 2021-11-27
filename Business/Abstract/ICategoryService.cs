using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        public List<Category> GetAll();
        public Category Get(Category category);
        public void Add(Category category);
        public void Update(Category category);
        public void Delete(Category category);
    }
}
