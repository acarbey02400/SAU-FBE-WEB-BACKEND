﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Program:IEntity
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
        public int academicDegreeId { get; set; }
        public int EbsId { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int DepartmentId { get; set; }
        public int ApplicationConditionId { get; set; }

    }
}
