using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class PrelectorPositionDto:IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProgramName { get; set; }
        public string PrelectorName { get; set; }
        public string PositionName { get; set; }
        public string PrelectorEmail { get; set; }
        public string PrelectorUrl { get; set; }
    }
}
