using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservation.Domain.Entities.Common;

namespace TravelReservation.Domain.Entities
{
    public class Client : BaseEntity
    {
        public string FullName { get; set; }
        public string Comment { get; set; }
        public string Photo { get; set; }

    }
}
