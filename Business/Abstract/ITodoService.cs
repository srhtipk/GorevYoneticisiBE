using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITodoService
    {
        public IDataResult<List<Todo>> GetAll();
        public IDataResult<List<Todo>> GetAllByCategoryId(int CategoryId);
        public IDataResult<Todo> Get(Todo todo);
        public IResult Add(Todo todo);
        public IResult Update(Todo todo);
        public IResult Delete(Todo todo);

    }
}
