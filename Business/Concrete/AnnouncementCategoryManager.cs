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
    public class AnnouncementCategoryManager:IAnnouncementCategoryService
    {
        IAnnouncementCategoryDal _announcementCategoryDal;
        public AnnouncementCategoryManager(IAnnouncementCategoryDal announcementCategoryDal)
        {
            _announcementCategoryDal = announcementCategoryDal;
        }

        public IResult add(AnnouncementCategory ac)
        {
            _announcementCategoryDal.Add(ac);
            return new SuccessResult();
        }

        public IResult delete(AnnouncementCategory ac)
        {
            _announcementCategoryDal.Delete(ac);
            return new SuccessResult();
        }

        public IDataResult<List<AnnouncementCategory>> getAll()
        {
            return new SuccessDataResult<List<AnnouncementCategory>>(_announcementCategoryDal.GetAll());
        }

        public IDataResult<List<AnnouncementCategory>> getByAnnouncementId(int announcementId)
        {
            return new SuccessDataResult<List<AnnouncementCategory>>
                (_announcementCategoryDal.GetAll(p => p.AnnouncementId == announcementId));
        }

        public IDataResult<List<AnnouncementCategory>> getByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<AnnouncementCategory>>
                (_announcementCategoryDal.GetAll(p => p.CategoryId == categoryId));
        }

        public IDataResult<AnnouncementCategory> getById(int id)
        {
            return new SuccessDataResult<AnnouncementCategory>(_announcementCategoryDal.Get(p => p.Id == id));
        }

        public IResult update(AnnouncementCategory ac)
        {
            _announcementCategoryDal.Update(ac);
            return new SuccessResult();
        }
    }
}
