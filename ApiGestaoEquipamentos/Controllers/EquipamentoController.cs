using ApiGestaoEquipamentos.Entities;
using Microsoft.AspNetCore.Mvc;
using ApiGestaoEquipamentos.Dtos;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace ApiGestaoEquipamentos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquipamentoController
    {
        private readonly IEquipamentoService equipamentoSerice;
        private readonly Imapper mapper;

        //construtor
        public EquipamentoController(IEquipamentoService equipamentoService, IMapper mapper)
        {
            this.equipamentoService = equipamentoService;
            this.mapper = mapper;
        }

        //o primeiro método: CREATE
        [HttpPost]
        public Task Criar([FromBody] EquipamentoDto equipamento)
        {
            var mappedEquipamento = mapper.Map<Equipamento>(equipamento);
            return equipamentoService.Criar(mappedEquipamento);
        }

        //Segundo método: Pesquisa por código, nome ou categoria
        [HttpGet($"search/{{searchTerm}}")]
        public async Task<IEnumerable<EquipamentoDto>> Selecionar([FromRoute] string searchTerm)
        {
            var equipamento = await EquipamentoService.Selecionar(searchTerm);
            return mapper.Map<IEnumerable<EquipamentoDto>>(equipamento);
        }

        //Terceiro método: Selecionar todos
        [HttpGet]
        public async Task<IEnumerable<EquipamentoDto>> SelecionarTodos()
        {
            var equipamentos = await EquipamentoService.Get();
            return mapper.Map<IEnumerable<EquipamentoDto>>(equipamentos);
        }

        //Quarto método: Atualizar
        [HttpPut($"{{id}}")]
        public Task Atualizar([FromRoute] int id, [FromBody]EquipamentoDto equipamento)
        {
            var mappedEquipamento = mapper.Map<Equipamento>(equipamento);
            return equipamentoService.Atualizar(mappedEquipamento);
        }

        //Quinto método: Deletar
        [HttpDelete($"{{id}}")]
        public Task Deletar(int id)
        {
            return equipamentoService.Deletar(id);
        }
    }
}
