using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelReservation.Domain.Entities;

namespace TravelReservation.Persistence.EntityBinding
{
    public class AboutBinding : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.Property(a=>a.Title).IsRequired().HasMaxLength(50);
            builder.Property(a=>a.Description).IsRequired().HasMaxLength(500);
            builder.Property(a=>a.Image).IsRequired().HasMaxLength(100);
            builder.Property(a=>a.Motto).IsRequired().HasMaxLength(100);
            builder.Property(a=>a.WhyChooseUs).IsRequired().HasMaxLength(500);

            builder.ToTable("Abouts");
        }
    }
    public class ClientBinding : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.Property(c=>c.FullName).IsRequired().HasMaxLength(50);
            builder.Property(c=>c.Comment).IsRequired().HasMaxLength(500);
            builder.Property(c=>c.Photo).IsRequired().HasMaxLength(100);

            builder.ToTable("Clients");
        }
    }
    public class ContactBinding : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property(c=>c.FullName).IsRequired().HasMaxLength(50);
            builder.Property(c=>c.Email).IsRequired().HasMaxLength(50);
            builder.Property(c=>c.Subject).IsRequired().HasMaxLength(100);
            builder.Property(c=>c.Message).IsRequired().HasMaxLength(500);

            builder.ToTable("Contacts");
        }
    }
    public class DestinationBinding : IEntityTypeConfiguration<Destination>
    {
        public void Configure(EntityTypeBuilder<Destination> builder)
        {
            builder.Property(d=>d.City).IsRequired().HasMaxLength(75);
            builder.Property(d=>d.Description).IsRequired().HasMaxLength(100);
            builder.Property(d=>d.Price).IsRequired();

            builder.ToTable("Destinations");
        }
    }
    public class GuideBinding : IEntityTypeConfiguration<Guide>
    {
        public void Configure(EntityTypeBuilder<Guide> builder)
        {
            builder.Property(g => g.Name).IsRequired().HasMaxLength(30);
            builder.Property(g => g.Surname).IsRequired().HasMaxLength(30);

            builder.ToTable("Guides");
        }
    }
    public class InformationBinding : IEntityTypeConfiguration<Information>
    {
        public void Configure(EntityTypeBuilder<Information> builder)
        {
            builder.Property(i=>i.Description).IsRequired().HasMaxLength(500);
            builder.Property(i=>i.Email).IsRequired().HasMaxLength(100);
            builder.Property(i=>i.Address).IsRequired().HasMaxLength(500);
            builder.Property(i=>i.Number).IsRequired().HasMaxLength(25);
            builder.Property(i=>i.MapLocation).IsRequired().HasMaxLength(250);
            builder.Property(i=>i.LinkedIn).IsRequired().HasMaxLength(100);
            builder.Property(i=>i.Facebook).IsRequired().HasMaxLength(100);
            builder.Property(i=>i.Github).IsRequired().HasMaxLength(100);

            builder.ToTable("Informations");
        }
    }
}
//public string Description { get; set; }
//public string Email { get; set; }
//public string Address { get; set; }
//public string Number { get; set; }
//public string MapLocation { get; set; }
//public string LinkedIn { get; set; }
//public string Facebook { get; set; }
//public string Github { get; set; }