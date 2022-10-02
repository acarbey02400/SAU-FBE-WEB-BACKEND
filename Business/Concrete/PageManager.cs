using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PageManager : IPageService
    {
        IPageDal _pageDal;
        public PageManager(IPageDal pageDal)
        {
            _pageDal=pageDal;
        }
        public IResult add(Page page)
        {
            _pageDal.Add(page);
            return new SuccessResult();
        }

        public IResult delete(Page page)
        {
            _pageDal.Delete(page);
            return new SuccessResult();
        }

        public IDataResult<List<Page>> getAll()
        {
            return new SuccessDataResult<List<Page>>(_pageDal.GetAll());
        }

        public IDataResult<List<Page>> getByCategoryId(int id)
        {
            return new SuccessDataResult<List<Page>>(_pageDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult<Page> getById(int id)
        {
            return new SuccessDataResult<Page>(_pageDal.Get(p => p.Id == id));
        }

        public IDataResult<List<Page>> getByMainTitleId(int id)
        {
            return new SuccessDataResult<List<Page>>(_pageDal.GetAll(p => p.MainTitleId == id));
        }

        public IDataResult<List<Page>> getBySubTitleId(int id)
        {
            return new SuccessDataResult<List<Page>>(_pageDal.GetAll(p => p.SubTitleId == id));
        }

        public IDataResult<List<PageDetailsDto>> getPageDetails()
        {
            return new SuccessDataResult<List<PageDetailsDto>>(_pageDal.GetPageDetails());
        }

        public IResult update(Page page)
        {
            _pageDal.Update(page);
            return new SuccessResult();
        }
    }
}
