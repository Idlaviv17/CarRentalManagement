﻿using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                    new Model
                    {
                        Id = 1,
                        CreatedBy = "System",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        Name = "Prius",
                        UpdatedBy = "System"
                    },
                    new Model
                    {
                        Id = 2,
                        CreatedBy = "System",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        Name = "Corolla",
                        UpdatedBy = "System"
                    },
                    new Model
                    {
                        Id = 3,
                        CreatedBy = "System",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        Name = "Civic",
                        UpdatedBy = "System"
                    },
                    new Model
                    {
                        Id = 4,
                        CreatedBy = "System",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        Name = "CRV",
                        UpdatedBy = "System"
                    }
                );
        }
    }
}
