using System;
using SistemaOcorrencias.Models;
using SistemaOcorrencias.Repositories;

namespace SistemaOcorrencias.Services
{
    public class OcorrenciaService
    {
        private readonly IOcorrenciaRepository _repository;

        public OcorrenciaService(IOcorrenciaRepository repository)
        {
            _repository = repository;
        }

        public void RegistrarNovaOcorrencia(Ocorrencia ocorrencia)
        {
            if (string.IsNullOrWhiteSpace(ocorrencia.Descricao))
            {
                throw new ArgumentException("A descrição do problema é obrigatória.");
            }

            if (ocorrencia.IdDepartamento <= 0 || ocorrencia.MatriculaResponsavel <= 0)
            {
                throw new ArgumentException("Departamento ou Responsável inválidos.");
            }

            ocorrencia.Status = "Aberto";
            ocorrencia.DataAbertura = DateTime.Now;
            ocorrencia.NumeroCodigo = $"TI-{DateTime.Now.Year}-{new Random().Next(1000, 9999)}";

            _repository.Salvar(ocorrencia);
        }
    }
}