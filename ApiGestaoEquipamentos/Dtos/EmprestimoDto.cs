namespace ApiGestaoEquipamentos.Dtos
{
    public class EmprestimoDto
    {
        public int CodigoUnico { get; set; }

        public DateTime DataEmprestimo { get; set; }

        public DateTime DataPrevistaDevolucao { get; set; }

        public string Descricao { get; set; }

        public int ResponsavelEmprestimo { get; set; }

        public int ResponsavelDevolucao { get; set; }

        public string Status { get; set; }
    }
}
