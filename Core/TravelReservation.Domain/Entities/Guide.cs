using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservation.Domain.Entities.Common;

namespace TravelReservation.Domain.Entities
{
    public class Guide : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
