﻿using ControleFinanceiro.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinancerio.DAL.Mapeamentos
{
    public class TipoMap : IEntityTypeConfiguration<Tipo>
    {
        public void Configure(EntityTypeBuilder<Tipo> builder)
        {
            builder.HasKey(t => t.Tipoid);
            builder.Property(t => t.Nome).IsRequired().HasMaxLength(20);

            builder.HasMany(t => t.Categorias).WithOne(t => t.Tipo);

            builder.HasData(
                new Tipo
                {
                    Tipoid = 1,
                    Nome = "Despesa"
                },
                new Tipo
                {
                    Tipoid = 2,
                    Nome = "Ganho"
                });
            
            
            builder.ToTable("Tipos");
        }

    }


}