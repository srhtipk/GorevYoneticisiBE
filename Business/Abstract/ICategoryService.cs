using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        public IDataResult<List<Category>> GetAll();
        public IDataResult<Category> Get(Category category);
        public IResult Add(Category category);
        public IResult Update(Category category);
        public IResult Delete(Category category);
    }
}
