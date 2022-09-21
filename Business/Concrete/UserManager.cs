using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public IResult add(User user)
        {
           _userDal.Add(user);
            return new SuccessResult();
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.eMail == email);
        }
        public IResult delete(User user)
        {

            _userDal.Delete(user);
            return new SuccessResult();
        }

        public IDataResult<List<User>> getAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<User> getById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(p => p.id == id));
        }
        public IResult update(User user)
        {

            _userDal.Update(user);
            return new SuccessResult();
        }
    }
}
