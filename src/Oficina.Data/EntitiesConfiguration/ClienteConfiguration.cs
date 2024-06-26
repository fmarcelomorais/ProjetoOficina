﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oficina.Domain.Models;

namespace Oficina.Infrastructure.EntitiesConfiguration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Telefone).HasMaxLength(11).IsRequired();
            builder.Property(c => c.Email).HasMaxLength(255);

        }
    }
}
