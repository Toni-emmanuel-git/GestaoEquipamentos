using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;
namespace ApiGestaoEquipamentos.Entities
{
    public class Emprestimo
    {
        public int CodigoUnico {  get; set; }

        public DateTime DataEmprestimo { get; set; }

        public DateTime DataPrevistaDevolucao { get; set; }

        public string Descricao { get; set; }

        public int ResponsavelEmprestimo { get; set; }

        public int ResponsavelDevolucao { get; set; }

        public string Status {  get; set; }

    }
}
