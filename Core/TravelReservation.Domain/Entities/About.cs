using TravelReservation.Domain.Entities.Common;

namespace TravelReservation.Domain.Entities
{
    public class About : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Motto { get; set; }
        public string WhyChooseUs { get; set; }
       
    }
}
