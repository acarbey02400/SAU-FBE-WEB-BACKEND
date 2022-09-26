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
    public interface IProgramService
    {
        public IResult add(Program program);
        public IResult update(Program program);
        public IResult delete(Program program);
        public IDataResult<List<Program>> getAll();
        public IDataResult<Program> getById(int id);
        public IDataResult<List<Program>> getByAcademicDegreeId(int id);
        public IDataResult<List<Program>> getByEbsId(int id);
        public IDataResult<List<Program>> getByCategoryId(int id);


    }
}
