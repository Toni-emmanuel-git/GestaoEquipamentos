using System.Collections.Generic;
using System.Threading.Tasks;
using ApiGestaoEquipamentos.Entities;

namespace ApiGestaoEquipamentos.Services
{
    public class IEmprestimoService
    {
        Task<IEnumerable<Emprestimo>> ListaeEmprestimos();
    }
}
