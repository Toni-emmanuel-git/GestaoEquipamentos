using ApiGestaoEquipamentos.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace ApiGestaoEquipamentos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmprestimoController
    {
        private readonly IEmprestimoService emprestimoService;
        private readonly IMapper mapper;

        //construtor
        public EmprestimoController(IEmprestimoService emprestimoService, IMapper mapper)
        {
            this.emprestimoService = emprestimoService;
            this.mapper = mapper;
        }

        //o primeiro método: CREATE
        [HttpPost]
        public Task Criar([FromBody] EmprestimoDto emprestimo)
        {
            var mappedEmprestimo = mapper.Map<Emprestimo>(emprestimo);
            return emprestimoService.Criar(mappedEmprestimo);
        }

        //Segundo método: Pesquisa por código
        [HttpGet($"{{id}}")]
        public async Task<EmprestimoDto> Selecionar([FromRoute] int id)
        {
            var emprestimo = await emprestimoService.Get(id);
            return mapper.Map<emprestimoDto>(emprestimo);
        }

        //Terceiro método: Selecionar todos
        [HttpGet]
        public async Task<IEnumerable<EmprestimoDto>> SelecionarTodos()
        {
            var emprestimos = await EmprestimoService.Get();
            return mapper.Map<IEnumerable<EmprestimoDto>>(emprestimos);
        }

        //Quarto método: Atualizar
        [HttpPut($"{{id}}")]
        public Task Atualizar([FromRoute] int id, [FromBody]EmprestimoDto emprestimo)
        {
            var mappedEmprestimo = mapper.Map<Emprestimo>(emprestimo);
            return emprestimoService.Atualizar(id, mappedEmprestimo);
        }

        [HttpDelete($"{{id}}")]
        //Quinto método: Deletar
        public Task Deletar([FromRoute] int id)
        {
            return emprestimoService.Deletar(id);
        }
    }
}
