using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicationConditionService
    {
        public IResult add(ApplicationCondition applicationCondition);
        public IResult update(ApplicationCondition applicationCondition);
        public IResult delete(ApplicationCondition applicationCondition);
        public IDataResult<List<ApplicationCondition>> getAll();
        public IDataResult<ApplicationCondition> getById(int id);
    }
}
