using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPageService
    {
        public IResult add(Page page);
        public IResult update(Page page);
        public IResult delete(Page page);
        public IDataResult<List<Page>> getAll();
        public IDataResult<Page> getById(int id);
        public IDataResult<List<PageDetailsDto>> getPageDetails();
        public IDataResult<List<Page>> getByMainTitleId(int id);
        public IDataResult<List<Page>> getBySubTitleId(int id);
        public IDataResult<List<Page>> getByCategoryId(int id);
    }
}
