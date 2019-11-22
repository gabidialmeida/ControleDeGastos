using System;
using System.Collections.Generic;
using System.Text;
using ControleDeGastos.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ControleDeGastos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Gastos> Gastos { get; set; }
        public DbSet<ControleDeGastos.Models.Conta> Conta { get; set; }
        public DbSet<ControleDeGastos.Models.Orcamento> Orcamento { get; set; }
        public DbSet<ControleDeGastos.Models.Mes> Mes { get; set; }
        public DbSet<ControleDeGastos.Models.ItemOrcamento> ItemOrcamento { get; set; }
    }
}
