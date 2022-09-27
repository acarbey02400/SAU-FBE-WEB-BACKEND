﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Prelector:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PrelectorPositionId { get; set; }
        public string EMail { get; set; }
        public string Url { get; set; }

    }
}