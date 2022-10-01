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
    public class PrelectorPositionManager:IPrelectorPositionService
    {
        IPrelectorPositionDal _prelectorPositionDal;
        public PrelectorPositionManager(IPrelectorPositionDal prelectorPositionDal)
        {
            _prelectorPositionDal = prelectorPositionDal;
        }

        public IResult add(PrelectorPosition pp)
        {
            _prelectorPositionDal.Add(pp);
            return new SuccessResult();
        }

        public IResult delete(PrelectorPosition pp)
        {
            _prelectorPositionDal.Delete(pp);
            return new SuccessResult();
        }

        public IDataResult<List<PrelectorPosition>> getAll()
        {
            return new SuccessDataResult<List<PrelectorPosition>>(_prelectorPositionDal.GetAll());
        }

        public IDataResult<PrelectorPosition> getById(int id)
        {
            return new SuccessDataResult<PrelectorPosition>(_prelectorPositionDal.Get(p => p.Id == id));
        }

        public IDataResult<List<PrelectorPositionDto>> getByPrelectorPositionDetails()
        {
            return new SuccessDataResult<List<PrelectorPositionDto>>(_prelectorPositionDal.GetByPrelectorPositionDetails());
        }

        public IDataResult<List<PrelectorPositionDto>> getByPrelectorPositionDetailsForProgramId(int programId)
        {
            return new SuccessDataResult<List<PrelectorPositionDto>>(_prelectorPositionDal.GetByPrelectorPositionDetailsForProgramId(programId));
        }

        public IResult update(PrelectorPosition pp)
        {
            _prelectorPositionDal.Update(pp);
            return new SuccessResult();
        }
    }
}
