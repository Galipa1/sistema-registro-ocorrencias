using System.Collections.Generic;
using SistemaOcorrencias.Models;

namespace SistemaOcorrencias.Repositories
{
    public interface IOcorrenciaRepository
    {
        void Salvar(Ocorrencia ocorrencia);
        void AtualizarStatus(int id, string novoStatus);
        Ocorrencia BuscarPorId(int id);
        List<Ocorrencia> ListarTodas();
    }
}