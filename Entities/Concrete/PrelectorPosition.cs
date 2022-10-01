﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class PrelectorPosition:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProgramId { get; set; }
        public int PrelectorId { get; set; }
        public int PositionId { get; set; }

    }
}
