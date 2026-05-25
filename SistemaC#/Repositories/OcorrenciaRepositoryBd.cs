using System;
using System.Collections.Generic;
using Npgsql;
using SistemaOcorrencias.Models;

namespace SistemaOcorrencias.Repositories
{
    public class OcorrenciaRepositoryBd : IOcorrenciaRepository
    {
        
        private readonly string _connectionString = "Host=localhost;Port=5432;Username=postgres;Password=2402;Database=linguagem2";

        public void Salvar(Ocorrencia ocorrencia)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                string sql = @"INSERT INTO Ocorrencia (numero_codigo, descricao, status, id_departamento, matricula_responsavel) 
                               VALUES (@codigo, @descricao, @status, @idDepto, @matricula)";

                using (var command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("codigo", ocorrencia.NumeroCodigo);
                    command.Parameters.AddWithValue("descricao", ocorrencia.Descricao);
                    command.Parameters.AddWithValue("status", ocorrencia.Status);
                    command.Parameters.AddWithValue("idDepto", ocorrencia.IdDepartamento);
                    command.Parameters.AddWithValue("matricula", ocorrencia.MatriculaResponsavel);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void AtualizarStatus(int id, string novoStatus) { throw new NotImplementedException(); }
        public Ocorrencia BuscarPorId(int id) { throw new NotImplementedException(); }
        public List<Ocorrencia> ListarTodas() { throw new NotImplementedException(); }
    }
}