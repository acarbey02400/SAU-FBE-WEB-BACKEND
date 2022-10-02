using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ApplicationConditionTypeManager : IApplicationConditionTypeService
    {
        IApplicationConditionTypeDal _applicationConditionTypeDal;
        public ApplicationConditionTypeManager(IApplicationConditionTypeDal applicationConditionTypeDal)
        {
            _applicationConditionTypeDal = applicationConditionTypeDal;
        }

        public IResult add(ApplicationConditionType applicationConditionType)
        {
            _applicationConditionTypeDal.Add(applicationConditionType);
            return new SuccessResult();
        }

        public IResult delete(ApplicationConditionType applicationConditionType)
        {
            _applicationConditionTypeDal.Delete(applicationConditionType);
            return new SuccessResult();
        }

        public IDataResult<List<ApplicationConditionType>> getAll()
        {
            return new SuccessDataResult<List<ApplicationConditionType>>(_applicationConditionTypeDal.GetAll());
        }

        public IDataResult<ApplicationConditionType> getById(int id)
        {
            return new SuccessDataResult<ApplicationConditionType>(_applicationConditionTypeDal.Get(p => p.Id == id));
        }

        public IResult update(ApplicationConditionType applicationConditionType)
        {
            _applicationConditionTypeDal.Update(applicationConditionType);
            return new SuccessResult();
        }
    }
}
