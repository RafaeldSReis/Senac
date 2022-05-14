/* Lógico_1: */

CREATE TABLE Fornecedor (
    codfor INTEGER PRIMARY KEY,
    razaosocial VARCHAR,
    CNPJ VARCHAR,
    cidade VARCHAR,
    rua VARCHAR,
    estado VARCHAR,
    telefone VARCHAR,
    email VARCHAR,
    nomefan VARCHAR,
    bairro VARCHAR,
    cep VARCHAR
);

CREATE TABLE produtos (
    codpro INTEGER PRIMARY KEY,
    descricao VARCHAR,
    qtdatual INTEGER,
    valor FLOAT,
    qtdmin INTEGER,
    qtdm INTEGER,
    categoria VARCHAR,
    dataval DATE,
    unidade VARCHAR,
    fk_Fornecedor_codfor INTEGER,
    coditem INTEGER,
    qtd INTEGER,
    subtotal DOUBLE
);

CREATE TABLE clientes (
    codcli INTEGER PRIMARY KEY,
    nome VARCHAR,
    Rua VARCHAR,
    telefone VARCHAR,
    cpf VARCHAR,
    rg VARCHAR,
    cidade VARCHAR,
    bairro VARCHAR,
    cep VARCHAR,
    estado VARCHAR
);

CREATE TABLE venda (
    codven INTEGER PRIMARY KEY,
    dataven DATE,
    horaven TIME,
    valortotal FLOAT,
    fk_clientes_codcli INTEGER
);

CREATE TABLE tem (
    fk_produtos_codpro INTEGER,
    fk_venda_codven INTEGER
);
 
ALTER TABLE produtos ADD CONSTRAINT FK_produtos_2
    FOREIGN KEY (fk_Fornecedor_codfor)
    REFERENCES Fornecedor (codfor)
    ON DELETE CASCADE;
 
ALTER TABLE venda ADD CONSTRAINT FK_venda_2
    FOREIGN KEY (fk_clientes_codcli)
    REFERENCES clientes (codcli)
    ON DELETE CASCADE;
 
ALTER TABLE tem ADD CONSTRAINT FK_tem_1
    FOREIGN KEY (fk_produtos_codpro)
    REFERENCES produtos (codpro)
    ON DELETE RESTRICT;
 
ALTER TABLE tem ADD CONSTRAINT FK_tem_2
    FOREIGN KEY (fk_venda_codven)
    REFERENCES venda (codven)
    ON DELETE SET NULL;