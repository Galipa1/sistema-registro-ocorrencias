using System;

namespace SistemaOcorrencias.Models
{
    public class Ocorrencia
    {
        public int Id { get; set; }
        public string NumeroCodigo { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public DateTime DataAbertura { get; set; }
        public int IdDepartamento { get; set; }
        public int MatriculaResponsavel { get; set; }
    }
}