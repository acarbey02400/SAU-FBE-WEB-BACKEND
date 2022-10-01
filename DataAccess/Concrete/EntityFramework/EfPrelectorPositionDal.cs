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
    public class EfPrelectorPositionDal : EfEntityRepositoryBase<PrelectorPosition, FBEContext>, IPrelectorPositionDal
    {
        public List<PrelectorPositionDto> GetByPrelectorPositionDetails()
        {

            using (FBEContext context = new FBEContext())
            {
                var result = from pp in context.PrelectorPositions
                             join pr in context.Prelectors
                             on pp.PrelectorId equals pr.Id
                             join pg in context.Programs
                             on pp.ProgramId equals pg.Id
                             join ps in context.Positions
                             on pp.PositionId equals ps.Id


                             select new PrelectorPositionDto
                             {
                                 Id = pp.Id,
                                 Name = pp.Name,
                                 PositionName = ps.Name,
                                 PrelectorName = pr.Name,
                                 ProgramName = pg.Name,
                                 PrelectorEmail = pr.EMail,
                                 PrelectorUrl = pr.Url
                             };

                return result.ToList();
            }
        }

        public List<PrelectorPositionDto> GetByPrelectorPositionDetailsForProgramId(int programId)
        {
            using (FBEContext context = new FBEContext())
            {
                var result = from pp in context.PrelectorPositions
                             join pr in context.Prelectors
                             on pp.PrelectorId equals pr.Id
                             join pg in context.Programs
                             on programId equals pg.Id
                             join ps in context.Positions
                             on pp.PositionId equals ps.Id


                             select new PrelectorPositionDto
                             {
                                 Id = pp.Id,
                                 Name = pp.Name,
                                 PositionName = ps.Name,
                                 PrelectorName = pr.Name,
                                 ProgramName = pg.Name,
                                 PrelectorEmail = pr.EMail,
                                 PrelectorUrl = pr.Url
                             };

                return result.ToList();
            }
        }
    }
}
