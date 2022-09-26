using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class AnnouncementCategory:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AnnouncementId { get; set; }
        public int CategoryId { get; set; }

    }
}
