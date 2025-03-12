using System.Collections.Generic;
using ApiGestaoEquipamentos.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiGestaoEquipamentos.Services
{
    public class EmprestimoService
    {
        private readonly GestaoEquipamentosDbContext gestaoEquipamentosDbContext;

        private DbSet<Emprestimo> Emprestimos => gestaoEquipamentosDbContext.Emprestimos;

        public EmprestimoService(GestaoEquipamentosDbContext gestaoEquipamentosDbContext)
        {
            this.gestaoEquipamentosDbContext = gestaoEquipamentosDbContext;
        }
    }
}
