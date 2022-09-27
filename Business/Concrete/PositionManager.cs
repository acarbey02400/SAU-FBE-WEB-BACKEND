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
    public class PositionManager:IPositionService
    {
        IPositionDal _positionDal;
        public PositionManager(IPositionDal positionDal)
        {
            _positionDal = positionDal;
        }

        public IResult add(Position position)
        {
            _positionDal.Add(position);
            return new SuccessResult();
        }

        public IResult delete(Position position)
        {
            _positionDal.Delete(position);
            return new SuccessResult();
        }

        public IDataResult<List<Position>> getAll()
        {
            return new SuccessDataResult<List<Position>>(_positionDal.GetAll());
        }

        public IDataResult<Position> getById(int id)
        {
            return new SuccessDataResult<Position>(_positionDal.Get(p => p.Id == id));
        }

        public IResult update(Position position)
        {
            _positionDal.Update(position);
            return new SuccessResult();
        }
    }
}
