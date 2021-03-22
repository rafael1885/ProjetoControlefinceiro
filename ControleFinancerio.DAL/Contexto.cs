using ControleFinanceiro.BLL.Models;
using ControleFinancerio.DAL.Mapeamentos;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinancerio.DAL
{
    public class Contexto : IdentityDbContext<Usuario, Funcao, string>
    {
        public Dbset<Cartao> Cartoes { get; set; }

        public Dbset<Categoria> Categorias { get; set; }

        public Dbset<Despesa> Despesas { get; set; }

        public Dbset<Funcao> Funcoes { get; set; }

        public Dbset<Ganho> Ganhos { get; set; }

        public Dbset<Mes> Meses { get; set; }

        public Dbset<Tipo> Tipos { get; set; }

        public Dbset<Usuario> Usuarios { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CartaoMap());
            builder.ApplyConfiguration(new CategoriaMap());
            builder.ApplyConfiguration(new DespesaMap());
            builder.ApplyConfiguration(new FuncaoMap());
            builder.ApplyConfiguration(new GanhoMap());
            builder.ApplyConfiguration(new MesMap());
            builder.ApplyConfiguration(new TipoMap());
            builder.ApplyConfiguration(new UsuarioMap());
        }

    }
}

