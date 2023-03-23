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
    public class SubTitleManager : ISubTitleService
    {
        ISubTitleDal _subTitleDal;
        public SubTitleManager(ISubTitleDal subTitleDal)
        {
            _subTitleDal = subTitleDal;
        }

        public IResult add(SubTitle subTitle)
        {
            _subTitleDal.Add(subTitle);
            return new SuccessResult();
        }

        public IResult delete(SubTitle subTitle)
        {
            _subTitleDal.Delete(subTitle);
            return new SuccessResult();
        }

        public IDataResult<List<SubTitle>> getAll()
        {
            return new SuccessDataResult<List<SubTitle>>(_subTitleDal.GetAll());
        }

        public IDataResult<SubTitle> getById(int id)
        {
            return new SuccessDataResult<SubTitle>(_subTitleDal.Get(p => p.Id == id));
        }

        public IDataResult<List<SubTitle>> getByMainTitleId(int mainTitleId)
        {
            return new SuccessDataResult<List<SubTitle>>(_subTitleDal.GetAll(p => p.MainTitleId == mainTitleId));
        }

        public IResult update(SubTitle subTitle)
        {
            _subTitleDal.Update(subTitle);
            return new SuccessResult();
        }
    }
}
