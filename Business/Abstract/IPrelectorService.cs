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
    public interface IPrelectorService
    {
        public IResult add(Prelector prelector);
        User GetByMail(string email);
        public IResult update(Prelector prelector);
        public IResult delete(Prelector prelector);
        public IDataResult<List<Prelector>> getAll();
        public IDataResult<Prelector> getById(int id);
        public IDataResult<List<Prelector>> getByPrelectorPositionId(int PrelectorPositionId);
    }
}
