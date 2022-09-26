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
    public interface IAnnouncementService
    {
        public IResult add(Announcement announcement);
        public IDataResult<List<Announcement>> GetByStartDate(DateTime date);
        public IDataResult<List<Announcement>> GetByStopDate(DateTime date);
        public IResult update(Announcement announcement);
        public IResult delete(Announcement announcement);
        public IDataResult<List<Announcement>> getAll();
        public IDataResult<Announcement> getById(int id);
        public IDataResult<List<Announcement>> getByActiveAnnouncement();
        public IDataResult<List<Announcement>> getByInActiveAnnouncement();
    }
}
