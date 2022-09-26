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
    public interface IAnnouncementCategoryService
    {
        public IResult add(AnnouncementCategory ac);
        public IResult update(AnnouncementCategory ac);
        public IResult delete(AnnouncementCategory ac);
        public IDataResult<List<AnnouncementCategory>> getAll();
        public IDataResult<AnnouncementCategory> getById(int id);
        public IDataResult <List<AnnouncementCategory>> getByAnnouncementId(int announcementId);
        public IDataResult <List<AnnouncementCategory>> getByCategoryId(int categoryId);
    }
}
