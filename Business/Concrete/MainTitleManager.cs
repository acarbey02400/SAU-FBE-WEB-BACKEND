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
    public class MainTitleManager : IMainTitleService
    {
        IMainTitleDal _mainTitleDal;
        public MainTitleManager(IMainTitleDal mainTitleDal)
        {
            _mainTitleDal = mainTitleDal;
        }

        public IResult add(MainTitle mainTitle)
        {
            _mainTitleDal.Add(mainTitle);
            return new SuccessResult();
        }

        public IResult delete(MainTitle mainTitle)
        {
            _mainTitleDal.Delete(mainTitle);
            return new SuccessResult();
        }

        public IDataResult<List<MainTitle>> getAll()
        {
            return new SuccessDataResult<List<MainTitle>>(_mainTitleDal.GetAll());
        }

        public IDataResult<MainTitle> getById(int id)
        {
            return new SuccessDataResult<MainTitle>(_mainTitleDal.Get(p => p.Id == id));
        }

        public IResult update(MainTitle mainTitle)
        {
            _mainTitleDal.Update(mainTitle);
            return new SuccessResult();
        }
    }
}
