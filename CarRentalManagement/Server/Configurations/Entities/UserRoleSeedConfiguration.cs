using CarRentalManagement.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = "5418e8e3-b7a7-48e9-b310-e03c156b31fd",
                        UserId = "282e3eb4-a2e1-49b3-b4fd-7ce6b8d144ca"
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "e1b86601-8938-4216-a8f8-58926cd4f163",
                        UserId = "ca63949a-9f93-44aa-836c-3e7aa2cafb36"
                    }
                );
        }
    }
}
