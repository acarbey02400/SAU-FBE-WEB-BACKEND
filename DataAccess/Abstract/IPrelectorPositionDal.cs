using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IPrelectorPositionDal:IEntityRepository<PrelectorPosition>
    {
        List<PrelectorPositionDto> GetByPrelectorPositionDetails();
        List<PrelectorPositionDto> GetByPrelectorPositionDetailsForProgramId(int programId);
    }
}
