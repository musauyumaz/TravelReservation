using TravelReservation.Domain.Entities.Common;

namespace TravelReservation.Domain.Entities
{
    public class Destination : BaseEntity
    {
        public string City { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }

    }
}
