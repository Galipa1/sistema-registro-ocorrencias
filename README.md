# Sistema de Registro de Ocorrências

Este projeto consiste em um sistema completo de gerenciamento e registro de chamados e ocorrências, desenvolvido para otimizar o fluxo de suporte do departamento de informática de uma empresa. 

O software foi projetado e implementado seguindo rigorosamente as melhores práticas de Engenharia de Software, padrões de arquitetura modernos e os princípios da metodologia ágil.

## 🚀 Funcionalidades Implementadas

### 1. Controle de Acesso e Perfis Funcionais
* **Diretor:** Responsável pela gestão estratégica. Possui permissões exclusivas para cadastrar, listar e alterar os departamentos da empresa.
* **Gerente de Departamento:** Responsável pela equipe operacional do seu setor. Possui autonomia para cadastrar/alterar funcionários e realizar a abertura e acompanhamento de ocorrências.
* **Funcionário de TI:** Agente técnico designado para a resolução dos problemas reportados, com permissão de visualização e alteração do status dos chamados sob sua responsabilidade.

### 2. Gestão de Entidades (CRUDs)
* **Departamentos:** Controle contendo código, nome, descrição e status (Ativo/Inativo).
* **Diretor / Gerente / Funcionários:** Armazenamento estruturado de dados como matrícula, nome, departamento vinculado e status ocupacional (Em exercício ou inativo).
* **Registro de Ocorrências:** Módulo centralizado que permite abertura, edição e consulta de chamados. Cada ocorrência armazena o número do protocolo, descrição do problema, departamento solicitante, funcionário responsável, status atual e carimbos de data/hora (abertura e encerramento). O acesso é restrito ao gerente do setor e ao técnico encarregado.

## 🏗️ Arquitetura e Boas Práticas (SOLID & IoC)
A implementação do código-fonte aplicou conceitos avançados de arquitetura para garantir alta manutenibilidade e baixo acoplamento:
* **Inversão de Controle (IoC) & Injeção de Dependência:** As regras de negócio e serviços do sistema não dependem de implementações concretas de banco de dados, mas sim de interfaces abstratas (`Repositories`), facilitando a substituição da camada de persistência se necessário.
* **Princípio da Responsabilidade Única (SRP):** Classes de domínio (Entidades) servem puramente para o mapeamento de dados, enquanto a lógica de validação e persistência foi isolada em componentes especialistas.
* **Princípio da Inversão de Dependência (DIP):** Módulos de alto nível não dependem de módulos de baixo nível; ambos dependem de abstrações.

## 📁 Ciclo de Vida do Projeto (Artefatos de Engenharia)

O repositório foi estruturado para documentar visualmente todas as etapas de desenvolvimento do trabalho:

1.  **Gestão de Projetos (Kanban):** Fluxo de tarefas planejado e controlado via Trello, mapeando o progresso desde o Backlog inicial até a homologação de entrega.
2.  **Gestão de Versão:** Versionamento e histórico de evolução do código gerenciado de forma semântica via GitHub.
3.  **Idealização e Estratégia (Modelagem):** Diagrama de Classes UML detalhando a arquitetura das classes de serviço, entidades e interfaces de IoC.
4.  **UI Design (Prototipação):** Wireframes estruturais desenvolvidos para a validação prévia da experiência do usuário (UX) nas telas de Login, Dashboards operacionais e formulários.
5.  **Banco de Dados (MER):** Modelo Entidade-Relacionamento lógico que garante a integridade referencial e o mapeamento correto de chaves primárias (PK) e estrangeiras (FK).
6.  **Desenvolvimento:** Sistema completamente codificado, integrado e funcional.

## 🛠️ Tecnologias Utilizadas
* **Linguagem de Programação:** Orientada a Objetos (C# / .NET)
* **Banco de Dados:** SQL Relacional
* **Modelagem de Artefatos:** Draw.io (Linguagens Mermaid e PlantUML)
* **Gestão do Fluxo:** Trello

---
*Projeto desenvolvido como avaliação prática para a disciplina de Engenharia de Software.*
