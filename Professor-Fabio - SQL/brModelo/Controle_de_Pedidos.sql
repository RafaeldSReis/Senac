/* Controle_de_Pedidos: */

CREATE TABLE ProdutosGrupos (
    ID INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL,
    GrupDescricao NVARCHAR(30)
);

CREATE TABLE Produtos (
    ID INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL,
    ProdDescricao NVARCHAR(50),
    ProdUnidade NVARCHAR(20),
    fk_ProdutosGrupos_ID INTEGER,
    ProdValorCompra NUMERIC,
    ProdValorVenda NUMERIC
);

CREATE TABLE PedidosItens (
    ID INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL,
    fk_Pedidos_ID INTEGER,
    fk_Produtos_ID INTEGER,
    ItPeQuant NUMERIC,
    ItPeValorUnitario NUMERIC,
    ItPeValorTotal NUMERIC
);

CREATE TABLE Pedidos (
    ID INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL,
    PediData DATE,
    PediObservacao NVARCHAR(100),
    PediValorTotal INTEGER,
    fk_Clientes_ID INTEGER
);

CREATE TABLE Clientes (
    ID INTEGER PRIMARY KEY IDENTITY(1,1) NOT NULL,
    ClieNome NVARCHAR(40),
    ClieEndereco NVARCHAR(50),
    ClieCep NVARCHAR(9),
    ClieCidade NVARCHAR(30),
    ClieEstado NVARCHAR(2),
    ClieDataCadastro DATE
);
 
ALTER TABLE Produtos ADD CONSTRAINT FK_Produtos_2
    FOREIGN KEY (fk_ProdutosGrupos_ID)
    REFERENCES ProdutosGrupos (ID)
    ON DELETE CASCADE;
 
ALTER TABLE PedidosItens ADD CONSTRAINT FK_PedidosItens_2
    FOREIGN KEY (fk_Pedidos_ID)
    REFERENCES Pedidos (ID)
    ON DELETE CASCADE;
 
ALTER TABLE PedidosItens ADD CONSTRAINT FK_PedidosItens_3
    FOREIGN KEY (fk_Produtos_ID)
    REFERENCES Produtos (ID)
    ON DELETE CASCADE;
 
ALTER TABLE Pedidos ADD CONSTRAINT FK_Pedidos_2
    FOREIGN KEY (fk_Clientes_ID)
    REFERENCES Clientes (ID)
    ON DELETE CASCADE;