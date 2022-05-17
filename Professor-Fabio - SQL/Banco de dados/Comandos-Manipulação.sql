CREATE DATABASE alunos; --Criando o banco de dados

Use alunos;--selecionando o banco de dados a ser usuado

CREATE TABLE aluno ( -- Criando a tabela alunos
codigo int primary key not null,
nome varchar(50),
rg varchar(30),
cpf varchar(30),
rua varchar(50),
bairro varchar(50),
cidade varchar(50),
estado varchar(02));

sp_help aluno; --Visualiza a estrutura da tabela

