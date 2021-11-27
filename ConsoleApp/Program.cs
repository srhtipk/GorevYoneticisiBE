using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ITodoDal todoDal = new EfTodoDal();
            ITodoService todoService = new TodoManager(todoDal);
            ICategoryDal categoryDal = new EfCategoryDal();
            ICategoryService categoryService = new CategoryManager(categoryDal);

            //todoService.Add(new Entities.Concrete.Todo { CategoryId=1,TodoName="asdf4",IsCompleted=true });

            Console.WriteLine(todoService.GetAll().Message);

            foreach (var item in todoService.GetAllByCategoryId(1).Data)
            {
                Console.WriteLine(item.TodoName);
            }

            foreach (var item in categoryService.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }

        }
    }
}
