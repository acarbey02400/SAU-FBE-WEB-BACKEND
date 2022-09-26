using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProgramDto:IDto
    {
        public int Id { get; set; }
        public string ProgramName { get; set; }
        public string ProgramDetail { get; set; }
        public string AcademicDegree { get; set; }
        public List<Prelector> Prelectors { get; set; }
        public List<Announcement> Announcements { get; set; }
        public List<Category> Categories { get; set; }

    }
}
