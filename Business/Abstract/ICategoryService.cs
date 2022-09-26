using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        public IResult add(Category category);
        public IResult update(Category category);
        public IResult delete(Category category);
        public IDataResult<List<Category>> getAll();
        public IDataResult<Category> getById(int id);
    }
}
