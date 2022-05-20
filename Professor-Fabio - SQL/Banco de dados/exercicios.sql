CREATE TABLE [dbo].[Exercicio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[last_name] [varchar](50) NOT NULL,
	[phone] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[district] [varchar](50) NOT NULL,
	[state] [nchar](2) NOT NULL,
	[city] [varchar](20) NOT NULL,
	[country] [varchar](50) NOT NULL,
	[zip_code] [varchar](10) NOT NULL,
	[age] [varchar](3) NOT NULL);

INSERT [dbo].[Exercicio] ([name], [last_name], [phone], [email], [district], [state], [city], [country], [zip_code], [age]) VALUES (N'fulano', N'tals', N'12345695', N'teste@teste', N'na', N'sp', N'word', N'12458745', N'10',N'50');

DROP TABLE exercicio;

SELECT * FROM exercicio;

ALTER TABLE dbo.exercicio 
ADD nationality VARCHAR(20) NULL, height VARCHAR(50) NULL ;

UPDATE exercicio SET nationality = 'word' WHERE id = 5;
UPDATE exercicio SET height = '1.80' WHERE id = 5;

alter table exercicio alter column name varchar(30);
alter table exercicio alter column last_name varchar(40);
alter table exercicio alter column phone varchar(20);

sp_help exercicio;


alter table exercicio drop column city;
alter table exercicio drop column phone;
alter table exercicio drop column email;

delete from exercicio where id = 3;
delete from exercicio where id = 4;
delete from exercicio where id = 5;

delete from exercicio;

drop table exercicio;
use master;
drop database exercicio;