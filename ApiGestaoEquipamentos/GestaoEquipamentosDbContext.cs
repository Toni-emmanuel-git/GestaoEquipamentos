using ApiGestaoEquipamentos.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;

namespace ApiGestaoEquipamentos
{
    public class GestaoEquipamentosDbContext : DbContext
    {
        public GestaoEquipamentosDbContext(DbContextOptions<GestaoEquipamentosDbContext> options) : base(options) { }

        public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
    }
}
