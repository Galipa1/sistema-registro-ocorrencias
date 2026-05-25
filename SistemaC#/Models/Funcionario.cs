namespace SistemaOcorrencias.Models
{
    public class Funcionario
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }
        public int IdDepartamento { get; set; }
    }
}