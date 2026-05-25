namespace SistemaOcorrencias.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Status { get; set; }
    }
}