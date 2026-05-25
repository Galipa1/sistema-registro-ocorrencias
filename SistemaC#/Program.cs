using System;
using System.Collections.Generic; // Necessário para usar Listas
using SistemaOcorrencias.Models;
using SistemaOcorrencias.Repositories;
using SistemaOcorrencias.Services;

namespace SistemaOcorrencias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Sistema de Ocorrências...\n");

            IOcorrenciaRepository repositorio = new OcorrenciaRepositoryBd();
            OcorrenciaService servico = new OcorrenciaService(repositorio);

            // Aqui nós cadastramos os 5 membros do grupo e os problemas deles.
            List<Ocorrencia> simulacoes = new List<Ocorrencia>
            {
                new Ocorrencia { Descricao = "O servidor principal desligou e não liga mais.", IdDepartamento = 1, MatriculaResponsavel = 12345 }, // Gabriel (TI)
                new Ocorrencia { Descricao = "Meu mouse quebrou e preciso de um novo.", IdDepartamento = 1, MatriculaResponsavel = 22222 }, // Leonardo (TI)
                new Ocorrencia { Descricao = "O sistema de folha de pagamento travou na minha tela.", IdDepartamento = 2, MatriculaResponsavel = 33333 }, // Danilo (RH)
                new Ocorrencia { Descricao = "A impressora do financeiro está sem tinta.", IdDepartamento = 3, MatriculaResponsavel = 44444 }, // Bruno (Financeiro)
                new Ocorrencia { Descricao = "Preciso de um cabo de rede maior para minha mesa.", IdDepartamento = 1, MatriculaResponsavel = 55555 } // Luiz (TI)
            };

            // Sorteamos aleatorimante alguma ocorrência
            Random sorteador = new Random();
            int numeroSorteado = sorteador.Next(simulacoes.Count); // Sorteia um número de 0 a 4

            // Pega a ocorrência correspondente ao número sorteado
            Ocorrencia ocorrenciaDaVez = simulacoes[numeroSorteado];

            Console.WriteLine($"[SIMULAÇÃO] O funcionário de matrícula {ocorrenciaDaVez.MatriculaResponsavel} está tentando abrir um chamado...");
            Console.WriteLine($"Problema relatado: '{ocorrenciaDaVez.Descricao}'\n");

            try
            {
                // Manda salvar o que foi sorteado
                servico.RegistrarNovaOcorrencia(ocorrenciaDaVez);
                Console.WriteLine("[SUCESSO] Ocorrência salva com sucesso no Banco de Dados!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERRO] Deu erro ao salvar: {ex.Message}");
            }

            Console.WriteLine("\nPressione qualquer tecla para fechar...");
            Console.ReadLine();
        }
    }
}