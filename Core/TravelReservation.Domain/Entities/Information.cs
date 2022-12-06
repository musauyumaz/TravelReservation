using TravelReservation.Domain.Entities.Common;

namespace TravelReservation.Domain.Entities
{
    public class Information : BaseEntity
    {
        public string Description { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }
        public string MapLocation { get; set; }
        public string LinkedIn { get; set; }
        public string Facebook { get; set; }
        public string Github { get; set; }
    }
}
