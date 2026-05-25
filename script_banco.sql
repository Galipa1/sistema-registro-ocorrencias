--Criação da tabela base: Departamento
CREATE TABLE Departamento (
    id_departamento SERIAL PRIMARY KEY,
    codigo VARCHAR(50) NOT NULL UNIQUE,
    nome VARCHAR(255) NOT NULL,
    descricao TEXT,
    status BOOLEAN NOT NULL -- TRUE (Ativo) ou FALSE (Inativo)
);

--Criação da tabela: Diretor
CREATE TABLE Diretor (
    matricula INT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    status_exercicio BOOLEAN NOT NULL
);

--Criação da tabela: Gerente
CREATE TABLE Gerente (
    matricula INT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    status BOOLEAN NOT NULL,
    id_departamento INT NOT NULL,
    CONSTRAINT FK_Gerente_Departamento FOREIGN KEY (id_departamento) 
        REFERENCES Departamento(id_departamento)
);

--Criação da tabela: Funcionário
CREATE TABLE Funcionario (
    matricula INT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    status BOOLEAN NOT NULL,
    id_departamento INT NOT NULL,
    CONSTRAINT FK_Funcionario_Departamento FOREIGN KEY (id_departamento) 
        REFERENCES Departamento(id_departamento)
);

--Criação da tabela: Ocorrência
CREATE TABLE Ocorrencia (
    id_ocorrencia SERIAL PRIMARY KEY,
    numero_codigo VARCHAR(50) NOT NULL UNIQUE,
    descricao TEXT NOT NULL,
    status VARCHAR(50) NOT NULL, 
    data_abertura TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    id_departamento INT NOT NULL,
    matricula_responsavel INT NOT NULL,
    CONSTRAINT FK_Ocorrencia_Departamento FOREIGN KEY (id_departamento) 
        REFERENCES Departamento(id_departamento),
    CONSTRAINT FK_Ocorrencia_Funcionario FOREIGN KEY (matricula_responsavel) 
        REFERENCES Funcionario(matricula)
);


-- Inserindo 2 novos departamentos 
INSERT INTO Departamento (codigo, nome, descricao, status) 
VALUES 
('RH', 'Recursos Humanos', 'Gestão de pessoas e folha de pagamento', true),
('FIN', 'Financeiro', 'Gestão de contas e pagamentos', true);

-- Inserindo os integrantes do grupo e associando aos departamentos
INSERT INTO Funcionario (matricula, nome, status, id_departamento) 
VALUES 
(12345, 'Gabriel', true, 1), -- Gabriel no TI (ID 1)
(22222, 'Leonardo', true, 1), -- Leonardo no TI (ID 1)
(33333, 'Danilo', true, 2),   -- Danilo no RH (ID 2)
(44444, 'Bruno', true, 3),    -- Bruno no Financeiro (ID 3)
(55555, 'Luiz', true, 1);     -- Luiz no TI (ID 1)
