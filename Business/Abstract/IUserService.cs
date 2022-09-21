using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        public IResult add(User user);
        User GetByMail(string email);
        public IResult update(User user);
        public IResult delete(User user);
        public IDataResult<List<User>> getAll();
        public IDataResult<User> getById(int id);
    }
}
