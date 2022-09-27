using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPositionService
    {
        public IResult add(Position position);
        public IResult update(Position position);
        public IResult delete(Position position);
        public IDataResult<List<Position>> getAll();
        public IDataResult<Position> getById(int id);
    }
}
