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
    public class EfPorgramDal:EfEntityRepositoryBase<Program,FBEContext>,IProgramDal
    {
        public List<ProgramDetailDto> GetByProgramDetails()
        {
            using (FBEContext context = new FBEContext())
            {
                var result = from p in context.Programs
                             join c in context.Categories
                             on p.CategoryId equals c.Id
                             join a in context.AcademicDegrees
                             on p.academicDegreeId equals a.Id
                             join d in context.Departments
                             on p.DepartmentId equals d.Id
                             join an in context.Announcements
                             on p.CategoryId equals an.CategoryId

                             select new ProgramDetailDto 
                             { Id=p.Id, AcademicDegree=a.Name, DepartmentName=d.Name,
                                 ProgramDetail=p.Description, ProgramName=p.Name};

                return result.ToList();
            }

        }
       
    }
}
