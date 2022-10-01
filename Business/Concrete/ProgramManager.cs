using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProgramManager : IProgramService
    {
        IProgramDal _programDal;
        public ProgramManager(IProgramDal programDal)
        {
            _programDal = programDal;
        }

        public IResult add(Program program)
        {
            _programDal.Add(program);
            return new SuccessResult();
        }

        public IResult delete(Program program)
        {
            _programDal.Delete(program);
            return new SuccessResult();
        }

        public IDataResult<List<Program>> getAll()
        {
            return new SuccessDataResult<List<Program>>(_programDal.GetAll());
        }

        public IDataResult<List<Program>> getByAcademicDegreeId(int id)
        {
            return new SuccessDataResult<List<Program>>(_programDal.GetAll(p => p.academicDegreeId == id));
        }

        public IDataResult<List<Program>> getByCategoryId(int id)
        {
            return new SuccessDataResult<List<Program>>(_programDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult<List<Program>> getByDepartmentId(int id)
        {
           return new SuccessDataResult<List<Program>>(_programDal.GetAll(p => p.DepartmentId == id));
        }

        public IDataResult<List<Program>> getByEbsId(int id)
        {
            return new SuccessDataResult<List<Program>>(_programDal.GetAll(p => p.EbsId == id));
        }

        public IDataResult<Program> getById(int id)
        {
            return new SuccessDataResult<Program>(_programDal.Get(p => p.Id == id));
        }

        public IDataResult<List<ProgramDetailDto>> getByProgramDetail()
        {
            return new SuccessDataResult<List<ProgramDetailDto>>();
        }

        public IResult update(Program program)
        {
            _programDal.Update(program);
            return new SuccessResult();
        }
    }
}
