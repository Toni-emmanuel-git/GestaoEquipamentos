using System.Collections.Generic;
using ApiGestaoEquipamentos.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiGestaoEquipamentos.Services
{
    public class EquipamentoService
    {
        private readonly GestaoEquipamentosDbContext gestaoEquipamentosDbContext;

        private DbSet<Equipamento> Equipamentos => gestaoEquipamentosDbContext.Equipamentos;

        public EquipamentoService(GestaoEquipamentosDbContext gestaoEquipamentosDbContext)
        {
            this.gestaoEquipamentosDbContext = gestaoEquipamentosDbContext;
        }
    }
}
