using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMainTitleService
    {
        public IResult add(MainTitle mainTitle);
        public IResult update(MainTitle mainTitle);
        public IResult delete(MainTitle mainTitle);
        public IDataResult<List<MainTitle>> getAll();
        public IDataResult<MainTitle> getById(int id);
    }
}
