using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProgramDetailDto:IDto
    {
        public int Id { get; set; }
        public string ProgramName { get; set; }
        public string ProgramDetail { get; set; }
        public string AcademicDegree { get; set; }
        public string DepartmentName { get; set; }
    
    }
}
