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
    public class ApplicationConditionManager : IApplicationConditionService
    {
        IApplicationConditionDal _applicationConditionDal;
        public ApplicationConditionManager(IApplicationConditionDal applicationConditionDal)
        {
            _applicationConditionDal = applicationConditionDal;
        }

        public IResult add(ApplicationCondition applicationCondition)
        {
            _applicationConditionDal.Add(applicationCondition);
            return new SuccessResult();
        }

        public IResult delete(ApplicationCondition applicationCondition)
        {
            _applicationConditionDal.Delete(applicationCondition);
            return new SuccessResult();
        }

        public IDataResult<List<ApplicationCondition>> getAll()
        {
            return new SuccessDataResult<List<ApplicationCondition>>(_applicationConditionDal.GetAll());
        }

        public IDataResult<ApplicationCondition> getById(int id)
        {
            return new SuccessDataResult<ApplicationCondition>
                (_applicationConditionDal.Get(p => p.Id == id));
        }

        public IResult update(ApplicationCondition applicationCondition)
        {
            _applicationConditionDal.Update(applicationCondition);
            return new SuccessResult();
        }
    }
}
