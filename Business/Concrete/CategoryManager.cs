using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult();
        }

        public IResult delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult();
        }

        public IDataResult<List<Category>> getAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IDataResult<Category> getById(int id)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(p=>p.Id==id));
        }

        public IResult update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult();

        }
    }
}
