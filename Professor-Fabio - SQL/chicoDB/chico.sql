USE [master]
GO
/****** Object:  Database [chico]    Script Date: 13/05/2022 20:39:26 ******/
CREATE DATABASE [chico]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'chico', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\chico.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'chico_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\chico_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [chico] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [chico].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [chico] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [chico] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [chico] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [chico] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [chico] SET ARITHABORT OFF 
GO
ALTER DATABASE [chico] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [chico] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [chico] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [chico] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [chico] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [chico] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [chico] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [chico] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [chico] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [chico] SET  DISABLE_BROKER 
GO
ALTER DATABASE [chico] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [chico] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [chico] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [chico] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [chico] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [chico] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [chico] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [chico] SET RECOVERY FULL 
GO
ALTER DATABASE [chico] SET  MULTI_USER 
GO
ALTER DATABASE [chico] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [chico] SET DB_CHAINING OFF 
GO
ALTER DATABASE [chico] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [chico] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [chico] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [chico] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [chico] SET QUERY_STORE = OFF
GO
USE [chico]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 13/05/2022 20:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[codcli] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[cfp] [varchar](50) NOT NULL,
	[rg] [varchar](50) NOT NULL,
	[rua] [varchar](50) NOT NULL,
	[telefone] [varchar](50) NOT NULL,
	[cidade] [varchar](50) NOT NULL,
	[cep] [varchar](50) NOT NULL,
	[bairro] [varchar](50) NOT NULL,
	[estado] [nchar](2) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[codcli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fornecedores]    Script Date: 13/05/2022 20:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecedores](
	[codfor] [int] IDENTITY(1,1) NOT NULL,
	[razaosocial] [varchar](50) NOT NULL,
	[nomefab] [varchar](50) NOT NULL,
	[cnpj] [varchar](50) NOT NULL,
	[rua] [varchar](50) NOT NULL,
	[bairro] [varchar](50) NOT NULL,
	[estado] [nchar](2) NOT NULL,
	[telefone] [varchar](20) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[cep] [varchar](10) NOT NULL,
	[cidade] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Fornecedores] PRIMARY KEY CLUSTERED 
(
	[codfor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Itensvendas]    Script Date: 13/05/2022 20:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Itensvendas](
	[coditem] [int] IDENTITY(1,1) NOT NULL,
	[qtd] [int] NOT NULL,
	[subtotal] [float] NOT NULL,
	[codven] [int] NOT NULL,
	[codpro] [int] NOT NULL,
 CONSTRAINT [PK_Itensvendas] PRIMARY KEY CLUSTERED 
(
	[coditem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produtos]    Script Date: 13/05/2022 20:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produtos](
	[codpro] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](50) NOT NULL,
	[valor] [float] NOT NULL,
	[qtdatual] [int] NOT NULL,
	[qtdmin] [int] NOT NULL,
	[qtdmax] [int] NOT NULL,
	[categoria] [varchar](50) NOT NULL,
	[dataval] [date] NOT NULL,
	[unidade] [varchar](50) NOT NULL,
	[codfor] [int] NOT NULL,
 CONSTRAINT [PK_Produtos] PRIMARY KEY CLUSTERED 
(
	[codpro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vendas]    Script Date: 13/05/2022 20:39:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendas](
	[codven] [int] IDENTITY(1,1) NOT NULL,
	[dataven] [date] NOT NULL,
	[hora] [time](7) NOT NULL,
	[valortotal] [float] NOT NULL,
	[codcli] [int] NOT NULL,
 CONSTRAINT [PK_vendas] PRIMARY KEY CLUSTERED 
(
	[codven] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([codcli], [nome], [cfp], [rg], [rua], [telefone], [cidade], [cep], [bairro], [estado]) VALUES (1, N'fulano', N'123654789', N'12345695', N'bebedouro', N'974581569', N'catanduva', N'15600-884', N'santa rosa', N'sp')
INSERT [dbo].[Clientes] ([codcli], [nome], [cfp], [rg], [rua], [telefone], [cidade], [cep], [bairro], [estado]) VALUES (2, N'souRuimParaNOmes', N'78945621', N'78458513', N'serioMuitoRuim', N'874569125', N'sao paulo', N'8004-8546', N'tabajara', N'rn')
INSERT [dbo].[Clientes] ([codcli], [nome], [cfp], [rg], [rua], [telefone], [cidade], [cep], [bairro], [estado]) VALUES (3, N'pedro', N'784589456', N'74512563', N'brasil', N'45125636587', N'rio de janeiro', N'9999-978', N'santos', N'pr')
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Fornecedores] ON 

INSERT [dbo].[Fornecedores] ([codfor], [razaosocial], [nomefab], [cnpj], [rua], [bairro], [estado], [telefone], [email], [cep], [cidade]) VALUES (1, N'coca-cola', N'coca', N'123456001', N'brasil', N'centro', N'sp', N'123456789', N'teste@teste', N'15800-000', N'catanduva')
INSERT [dbo].[Fornecedores] ([codfor], [razaosocial], [nomefab], [cnpj], [rua], [bairro], [estado], [telefone], [email], [cep], [cidade]) VALUES (2, N'poty', N'poty', N'1234569001', N'brasil', N'centro', N'sp', N'456842894', N'teste1@teste', N'15800-500', N'catanduva')
INSERT [dbo].[Fornecedores] ([codfor], [razaosocial], [nomefab], [cnpj], [rua], [bairro], [estado], [telefone], [email], [cep], [cidade]) VALUES (3, N'seila', N'naosei', N'1234567', N'santos', N'centro', N'rj', N'789456123', N'teste2@teste', N'15900-888', N'rio de janeiro')
SET IDENTITY_INSERT [dbo].[Fornecedores] OFF
GO
SET IDENTITY_INSERT [dbo].[Itensvendas] ON 

INSERT [dbo].[Itensvendas] ([coditem], [qtd], [subtotal], [codven], [codpro]) VALUES (1, 10, 51, 1, 3)
INSERT [dbo].[Itensvendas] ([coditem], [qtd], [subtotal], [codven], [codpro]) VALUES (2, 50, 1000, 2, 5)
INSERT [dbo].[Itensvendas] ([coditem], [qtd], [subtotal], [codven], [codpro]) VALUES (3, 100, 2000, 3, 6)
SET IDENTITY_INSERT [dbo].[Itensvendas] OFF
GO
SET IDENTITY_INSERT [dbo].[Produtos] ON 

INSERT [dbo].[Produtos] ([codpro], [descricao], [valor], [qtdatual], [qtdmin], [qtdmax], [categoria], [dataval], [unidade], [codfor]) VALUES (3, N'coca-cola', 7, 10, 5, 20, N'bebida', CAST(N'2024-02-22' AS Date), N'lata', 1)
INSERT [dbo].[Produtos] ([codpro], [descricao], [valor], [qtdatual], [qtdmin], [qtdmax], [categoria], [dataval], [unidade], [codfor]) VALUES (5, N'cerveja', 5, 50, 100, 200, N'bebida', CAST(N'8888-08-08' AS Date), N'lata', 2)
INSERT [dbo].[Produtos] ([codpro], [descricao], [valor], [qtdatual], [qtdmin], [qtdmax], [categoria], [dataval], [unidade], [codfor]) VALUES (6, N'pao', 2, 50, 100, 200, N'pao', CAST(N'2050-12-22' AS Date), N'massa', 3)
SET IDENTITY_INSERT [dbo].[Produtos] OFF
GO
SET IDENTITY_INSERT [dbo].[Vendas] ON 

INSERT [dbo].[Vendas] ([codven], [dataven], [hora], [valortotal], [codcli]) VALUES (1, CAST(N'2022-05-13' AS Date), CAST(N'08:00:00' AS Time), 500, 1)
INSERT [dbo].[Vendas] ([codven], [dataven], [hora], [valortotal], [codcli]) VALUES (2, CAST(N'1700-08-08' AS Date), CAST(N'08:50:00' AS Time), 800, 2)
INSERT [dbo].[Vendas] ([codven], [dataven], [hora], [valortotal], [codcli]) VALUES (3, CAST(N'0100-01-01' AS Date), CAST(N'10:00:00' AS Time), 2022, 3)
SET IDENTITY_INSERT [dbo].[Vendas] OFF
GO
ALTER TABLE [dbo].[Itensvendas]  WITH CHECK ADD  CONSTRAINT [FK_Itensvendas_Produtos] FOREIGN KEY([codpro])
REFERENCES [dbo].[Produtos] ([codpro])
GO
ALTER TABLE [dbo].[Itensvendas] CHECK CONSTRAINT [FK_Itensvendas_Produtos]
GO
ALTER TABLE [dbo].[Itensvendas]  WITH CHECK ADD  CONSTRAINT [FK_Itensvendas_Vendas] FOREIGN KEY([codven])
REFERENCES [dbo].[Vendas] ([codven])
GO
ALTER TABLE [dbo].[Itensvendas] CHECK CONSTRAINT [FK_Itensvendas_Vendas]
GO
ALTER TABLE [dbo].[Produtos]  WITH CHECK ADD  CONSTRAINT [FK_Produtos_Fornecedores] FOREIGN KEY([codfor])
REFERENCES [dbo].[Fornecedores] ([codfor])
GO
ALTER TABLE [dbo].[Produtos] CHECK CONSTRAINT [FK_Produtos_Fornecedores]
GO
ALTER TABLE [dbo].[Vendas]  WITH CHECK ADD  CONSTRAINT [FK_Vendas_Clientes] FOREIGN KEY([codcli])
REFERENCES [dbo].[Clientes] ([codcli])
GO
ALTER TABLE [dbo].[Vendas] CHECK CONSTRAINT [FK_Vendas_Clientes]
GO
USE [master]
GO
ALTER DATABASE [chico] SET  READ_WRITE 
GO
