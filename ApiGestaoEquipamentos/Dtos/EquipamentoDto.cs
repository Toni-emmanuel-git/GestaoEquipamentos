namespace ApiGestaoEquipamentos.Dtos
{
    public class EquipamentoDto
    {
        public int CodigoUnico { get; set; }
        public string NomeEquipamento { get; set; }

        public string Marca { get; set; }

        public string Estado { get; set; }

        public DateTime DataAquisicao { get; set; }
    }
}
