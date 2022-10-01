using Business.Abstract;
using Core.Entities.Concrete;
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
    public class PrelectorManager : IPrelectorService
    {
        IPrelectorDal _prelectorDal;
        public PrelectorManager(IPrelectorDal prelectorDal)
        {
            _prelectorDal = prelectorDal;
        }

        public IResult add(Prelector prelector)
        {
            _prelectorDal.Add(prelector);
            return new SuccessResult();
        }

        public IResult delete(Prelector prelector)
        {
            _prelectorDal.Delete(prelector);    
            return new SuccessResult();
        }

        public IDataResult<List<Prelector>> getAll()
        {
            return new SuccessDataResult<List<Prelector>>(_prelectorDal.GetAll());
        }

        public IDataResult<Prelector> getById(int id)
        {
            return new SuccessDataResult<Prelector>(_prelectorDal.Get(p => p.Id == id));
        }

        public IDataResult<Prelector> GetByMail(string email)
        {
            return new SuccessDataResult<Prelector>(_prelectorDal.Get(p => p.EMail == email));
        }

       

        public IResult update(Prelector prelector)
        {
            _prelectorDal.Update(prelector);
            return new SuccessResult();
        }
    }
}
