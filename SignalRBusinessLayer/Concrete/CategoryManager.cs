using SignalR.EntityLayer.Entities;
using SignalRBusinessLayer.Abstract;
using SignalRDataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal; 
        }

        public int ActiveCategoryCount()
        {
            return _categoryDal.ActiveCategoryCount();
        }

        public void Add(Category entity)
        {
            _categoryDal.Add(entity);   
        }

        public int CategoryCount()
        {
            return _categoryDal.CategoryCount();    
        }

        public void Delete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public List<Category> GetAll()
        {
             return _categoryDal.GetAll();
        }

        public Category GetById(int id)
        {
           return  _categoryDal.GetById(id);
        }

        public Category GetCategoryByName(string name)
        {
            if (name != null)
            {
                return _categoryDal.GetCategoryByName(name);
            }
            return null;
        }

        public int PassiveCategoryCount()
        {
            return _categoryDal.PassiveCategoryCount();
        }

        public void Update(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
