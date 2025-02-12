using AnyReservationTemp.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AnyReservationTemp.Components.Entities
{
    public class MemberSeed : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.HasData(
            new Member
            {
                Id = 1,
                Name = "Owen member",
                Contact = "8858 6939",
                EmailAddress = "owen@gmail.com",
                MembershipLevel = "Basic",
                JoinDate = DateTime.Now
            },
            new Member
            {
                Id = 2,
                Name = "Vinh member",
                Contact = "8888 8888",
                EmailAddress = "vinh@gmail.com",
                MembershipLevel = "Basic",
                JoinDate = DateTime.Now
            }
            );
        }
    }
}

        
   