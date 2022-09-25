using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;
        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public IResult add(Announcement announcement)
        {
            _announcementDal.Add(announcement);
            return new SuccessResult();
        }

        public IResult delete(Announcement announcement)
        {
            _announcementDal.Delete(announcement);
            return new SuccessResult();
        }

        public IDataResult<List<Announcement>> getAll()
        {
            return new SuccessDataResult<List<Announcement>>(_announcementDal.GetAll());
        }

        public IDataResult<List<Announcement>> getByActiveAnnouncement()
        {
            return new SuccessDataResult<List<Announcement>>(_announcementDal.GetAll(p => p.StartDate <= DateTime.Now).Where(p=>p.status==true).ToList());
        }

        public IDataResult<List<Announcement>> getByActiveInAnnouncement()
        {
            return new SuccessDataResult<List<Announcement>>(_announcementDal.GetAll(p => p.StartDate >= DateTime.Now).Where(p => p.status == false).ToList());
        }

        public IDataResult<Announcement> getById(int id)
        {
            return new SuccessDataResult<Announcement>(_announcementDal.Get(p => p.Id == id));
        }

        public IDataResult<List<Announcement>> GetByStartDate(DateTime date)
        {
            return new SuccessDataResult<List<Announcement>>(_announcementDal.GetAll(p=>p.StartDate==date));
        }

        public IDataResult<List<Announcement>> GetByStopDate(DateTime date)
        {
            return new SuccessDataResult<List<Announcement>>(_announcementDal.GetAll(p => p.StopDate == date));
        }

        public IResult update(Announcement announcement)
        {
            _announcementDal.Update(announcement);
            return new SuccessResult();
        }
    }
}
