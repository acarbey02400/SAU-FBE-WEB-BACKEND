using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ApplicationCondition : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ApplicationConditionTypeId { get; set; }
        public DateTime AcademicYear { get; set; }
        public string Period { get; set; }
        public int Quota { get; set; }
        public int QuotaForLateralTransfer { get; set; }
        public double MinUndergraduateAverage { get; set; }
        public double MinAlesPoint{ get; set; }
        public double MinOldGrePoint { get; set; }
        public double MinNewGrePoint { get; set; }
        public string LanguageRequirement { get; set; }
        public string MyProperty { get; set; }
        public string AcceptedPrograms { get; set; }
    }
}
