using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicationConditionTypeService
    {
        public IResult add(ApplicationConditionType applicationConditionType);
        public IResult update(ApplicationConditionType applicationConditionType);
        public IResult delete(ApplicationConditionType applicationConditionType);
        public IDataResult<List<ApplicationConditionType>> getAll();
        public IDataResult<ApplicationConditionType> getById(int id);
    }
}
