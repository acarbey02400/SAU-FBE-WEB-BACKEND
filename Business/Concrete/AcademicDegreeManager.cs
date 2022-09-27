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
    public class AcademicDegreeManager:IAcademicDegreeService
    {
        IAcademicDegreeDal _academicDegreeDal;
        public AcademicDegreeManager(IAcademicDegreeDal academicDegreeDal)
        {
            _academicDegreeDal=academicDegreeDal;
        }

        public IResult add(AcademicDegree academicDegree)
        {
            _academicDegreeDal.Add(academicDegree);
            return new SuccessResult();
        }

        public IResult delete(AcademicDegree academicDegree)
        {
            _academicDegreeDal.Delete(academicDegree);
            return new SuccessResult();
        }

        public IDataResult<List<AcademicDegree>> getAll()
        {
            return new SuccessDataResult<List<AcademicDegree>>(_academicDegreeDal.GetAll());
        }

        public IDataResult<AcademicDegree> getById(int id)
        {
            return new SuccessDataResult<AcademicDegree>(_academicDegreeDal.Get(p => p.Id == id));
        }

        public IResult update(AcademicDegree academicDegree)
        {
            _academicDegreeDal.Update(academicDegree);
            return new SuccessResult();
        }
    }
}
