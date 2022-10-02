using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPageDal : EfEntityRepositoryBase<Page, FBEContext>, IPageDal
    {
        public List<PageDetailsDto> GetPageDetails()
        {
            using (FBEContext context = new FBEContext())
            {
                var result = from p in context.Pages
                             join c in context.Categories
                             on p.CategoryId equals c.Id
                             join m in context.MainTitles
                             on p.MainTitleId equals m.Id
                             join s in context.SubTitles
                             on p.SubTitleId equals s.Id
                             select new PageDetailsDto
                             {
                                 CategoryName = c.Name,
                                 Name = p.Name,
                                 Description = p.Description,
                                 Id = p.Id,
                                 MainTitleName = m.Name,
                                 SubTitleName = s.Name
                             };
                return result.ToList();

            }
        }
    }
}
