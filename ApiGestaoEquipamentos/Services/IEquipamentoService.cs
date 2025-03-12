using System.Collections.Generic;
using System.Threading.Tasks;
using ApiGestaoEquipamentos.Entities;

namespace ApiGestaoEquipamentos.Services
{
    public class IEquipamentoService
    {
        Task<IEnumerable<Equipamento>> ListarEquipamentos();

        Task<Equipamento> ObterEquipamentoPorId(int id);

        Task<Equipamento> AdicionarEquipamento(Equipamento equipamento);

        Task<bool> AtualizarEquipamento(Equipamento equipamento);

        Task<bool> RemoverEquipamento(int id);
    }
}
