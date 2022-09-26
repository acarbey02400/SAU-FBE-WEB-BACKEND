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
    public interface IAcademicDegreeService
    {
        public IResult add(AcademicDegree academicDegree);
        public IResult update(AcademicDegree academicDegree);
        public IResult delete(AcademicDegree academicDegree);
        public IDataResult<List<AcademicDegree>> getAll();
        public IDataResult<AcademicDegree> getById(int id);
    }
}
