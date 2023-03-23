using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISubTitleService
    {
        public IResult add(SubTitle subTitle);
        public IResult update(SubTitle subTitle);
        public IResult delete(SubTitle subTitle);
        public IDataResult<List<SubTitle>> getAll();
        public IDataResult<SubTitle> getById(int id);
        public IDataResult<List<SubTitle>> getByMainTitleId(int mainTitleId);
    }
}
