using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TodoManager : ITodoService
    {
        ITodoDal _todoDal;

        public TodoManager(ITodoDal todoDal)
        {
            _todoDal = todoDal;
        }
        public IResult Add(Todo todo)
        {
            _todoDal.Add(todo);
            return new SuccessResult(Messages.TodoAdded);
        }

        public IResult Delete(Todo todo)
        {
            _todoDal.Delete(todo);
            return new SuccessResult(Messages.TodoAdded);
        }

        public IDataResult<Todo> Get(Todo todo)
        {
            //return _todoDal.Get(t=>t.TodoId==todo.TodoId);
            var result= _todoDal.Get(t => t.TodoId == todo.TodoId);
            return new SuccessDataResult<Todo>(result,Messages.TodosListed);
        }

        public IDataResult<List<Todo>> GetAll()
        {
            //return _todoDal.GetAll();
            var result= _todoDal.GetAll();
            return new SuccessDataResult<List<Todo>>(result,Messages.TodosListed);
        }

        public IDataResult<List<Todo>> GetAllByCategoryId(int CategoryId)
        {
            //return _todoDal.GetAll(t => t.CategoryId == CategoryId);
            var result = _todoDal.GetAll(t => t.CategoryId == CategoryId);
            return new SuccessDataResult<List<Todo>>(result, Messages.TodosListedByCategory);
        }

        public IResult Update(Todo todo)
        {
            _todoDal.Update(todo);
            return new SuccessResult(Messages.TodoUpdated);
        }
    }
}
