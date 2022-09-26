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
    public interface IPrelectorPositionService
    {
        public IResult add(PrelectorPosition pp);
        public IResult update(PrelectorPosition pp);
        public IResult delete(PrelectorPosition pp);
        public IDataResult<List<PrelectorPosition>> getAll();
        public IDataResult<PrelectorPosition> getById(int id);
    }
}
