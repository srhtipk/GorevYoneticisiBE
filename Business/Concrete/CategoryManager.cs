using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult("Kategori eklendi.");
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult("Kategori silindi.");
        }

        public IDataResult<Category> Get(Category category)
        {
            var result= _categoryDal.Get(c=>c.CategoryId==category.CategoryId);
            return new SuccessDataResult<Category>(result,"Kategori listelendi.");
        }

        public IDataResult<List<Category>> GetAll()
        {
            var result= _categoryDal.GetAll();
            return new SuccessDataResult<List<Category>>(result,"Kategoriler listelendi.");
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult("Kategori güncellendi.");
        }
    }
}
