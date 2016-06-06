create database RPGSystem
GO
use RPGSystem
go

CREATE TABLE [Personagem] (
	idPersonagem int NOT NULL,
	nome varchar(100) NOT NULL,
	idHistoria int NOT NULL,
  CONSTRAINT [PK_PERSONAGEM] PRIMARY KEY CLUSTERED
  (
  [idPersonagem] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Atributo] (
	idAtributo int NOT NULL,
	tipo char(1) NOT NULL,
	nome varchar(50) NOT NULL,
	descricao varchar(255),
  CONSTRAINT [PK_ATRIBUTO] PRIMARY KEY CLUSTERED
  (
  [idAtributo] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Atributo_Personagem] (
	idPersonagem int NOT NULL,
	idAtributo int NOT NULL,
	valorInt int,
	valorStr varchar(255)
)
GO
CREATE TABLE [Historia] (
	idHistoria int NOT NULL,
	historia text NOT NULL,
	titulo varchar(255),
	capitulo varchar(255),
	startChapter bit NOT NULL DEFAULT '0',
  CONSTRAINT [PK_HISTORIA] PRIMARY KEY CLUSTERED
  (
  [idHistoria] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Caminho] (
	idCaminho int NOT NULL,
	idHistoriaOrigem int NOT NULL,
	idHistoriaDestino int NOT NULL,
	idCondicao int NOT NULL,
  CONSTRAINT [PK_CAMINHO] PRIMARY KEY CLUSTERED
  (
  [idCaminho] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [TipoCondicao] (
	idTipoCondicao int NOT NULL,
	nome varchar(100) NOT NULL,
	descricao text,
  CONSTRAINT [PK_TIPOCONDICAO] PRIMARY KEY CLUSTERED
  (
  [idTipoCondicao] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Condicao] (
	idCondicao int NOT NULL,
	idTipoCondicao int NOT NULL,
  CONSTRAINT [PK_CONDICAO] PRIMARY KEY CLUSTERED
  (
  [idCondicao] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Login] (
	idLogin int NOT NULL,
	login varchar(100) NOT NULL,
	senha varchar(255) NOT NULL,
	nivel char(1) DEFAULT 'J',
	email varchar(255),
  CONSTRAINT [PK_LOGIN] PRIMARY KEY CLUSTERED
  (
  [idLogin] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Login_Personagem] (
	idLoginPersonagem int NOT NULL,
	idLogin int NOT NULL,
	idPersonagem int NOT NULL,
  CONSTRAINT [PK_LOGIN_PERSONAGEM] PRIMARY KEY CLUSTERED
  (
  [idLoginPersonagem] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Item] (
	idItem int NOT NULL,
	nome varchar NOT NULL,
	statAtaque int,
  CONSTRAINT [PK_ITEM] PRIMARY KEY CLUSTERED
  (
  [idItem] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Atributo_Historia] (
	idAtributo int NOT NULL,
	idHistoria int NOT NULL
)
GO
CREATE TABLE [Item_Personagem] (
	idItem int NOT NULL,
	idPersonagem int NOT NULL
)
GO
CREATE TABLE [Item_Historia] (
	idHistoria int NOT NULL,
	idItem int NOT NULL
)
GO
ALTER TABLE [Personagem] WITH CHECK ADD CONSTRAINT [Personagem_fk0] FOREIGN KEY ([idHistoria]) REFERENCES [Historia]([idHistoria])
ON UPDATE CASCADE
GO
ALTER TABLE [Personagem] CHECK CONSTRAINT [Personagem_fk0]
GO


ALTER TABLE [Atributo_Personagem] WITH CHECK ADD CONSTRAINT [Atributo_Personagem_fk0] FOREIGN KEY ([idPersonagem]) REFERENCES [Personagem]([idPersonagem])
ON UPDATE CASCADE
GO
ALTER TABLE [Atributo_Personagem] CHECK CONSTRAINT [Atributo_Personagem_fk0]
GO
ALTER TABLE [Atributo_Personagem] WITH CHECK ADD CONSTRAINT [Atributo_Personagem_fk1] FOREIGN KEY ([idAtributo]) REFERENCES [Atributo]([idAtributo])
ON UPDATE CASCADE
GO
ALTER TABLE [Atributo_Personagem] CHECK CONSTRAINT [Atributo_Personagem_fk1]
GO


ALTER TABLE [Caminho] WITH CHECK ADD CONSTRAINT [Caminho_fk0] FOREIGN KEY ([idHistoriaOrigem]) REFERENCES [Historia]([idHistoria])
ON UPDATE CASCADE
GO
ALTER TABLE [Caminho] CHECK CONSTRAINT [Caminho_fk0]
GO
ALTER TABLE [Caminho] WITH CHECK ADD CONSTRAINT [Caminho_fk1] FOREIGN KEY ([idHistoriaDestino]) REFERENCES [Historia]([idHistoria])
ON UPDATE NO ACTION
on DELETE NO ACTION
GO
ALTER TABLE [Caminho] CHECK CONSTRAINT [Caminho_fk1]
GO
ALTER TABLE [Caminho] WITH CHECK ADD CONSTRAINT [Caminho_fk2] FOREIGN KEY ([idCondicao]) REFERENCES [Condicao]([idCondicao])
ON UPDATE CASCADE
GO
ALTER TABLE [Caminho] CHECK CONSTRAINT [Caminho_fk2]
GO


ALTER TABLE [Condicao] WITH CHECK ADD CONSTRAINT [Condicao_fk0] FOREIGN KEY ([idTipoCondicao]) REFERENCES [TipoCondicao]([idTipoCondicao])
ON UPDATE CASCADE
GO
ALTER TABLE [Condicao] CHECK CONSTRAINT [Condicao_fk0]
GO


ALTER TABLE [Login_Personagem] WITH CHECK ADD CONSTRAINT [Login_Personagem_fk0] FOREIGN KEY ([idLogin]) REFERENCES [Login]([idLogin])
ON UPDATE CASCADE
GO
ALTER TABLE [Login_Personagem] CHECK CONSTRAINT [Login_Personagem_fk0]
GO
ALTER TABLE [Login_Personagem] WITH CHECK ADD CONSTRAINT [Login_Personagem_fk1] FOREIGN KEY ([idPersonagem]) REFERENCES [Personagem]([idPersonagem])
ON UPDATE CASCADE
GO
ALTER TABLE [Login_Personagem] CHECK CONSTRAINT [Login_Personagem_fk1]
GO


ALTER TABLE [Atributo_Historia] WITH CHECK ADD CONSTRAINT [Atributo_Historia_fk0] FOREIGN KEY ([idAtributo]) REFERENCES [Atributo]([idAtributo])
ON UPDATE CASCADE
GO
ALTER TABLE [Atributo_Historia] CHECK CONSTRAINT [Atributo_Historia_fk0]
GO
ALTER TABLE [Atributo_Historia] WITH CHECK ADD CONSTRAINT [Atributo_Historia_fk1] FOREIGN KEY ([idHistoria]) REFERENCES [Historia]([idHistoria])
ON UPDATE CASCADE
GO
ALTER TABLE [Atributo_Historia] CHECK CONSTRAINT [Atributo_Historia_fk1]
GO

ALTER TABLE [Item_Personagem] WITH CHECK ADD CONSTRAINT [Item_Personagem_fk0] FOREIGN KEY ([idItem]) REFERENCES [Item]([idItem])
ON UPDATE CASCADE
GO
ALTER TABLE [Item_Personagem] CHECK CONSTRAINT [Item_Personagem_fk0]
GO
ALTER TABLE [Item_Personagem] WITH CHECK ADD CONSTRAINT [Item_Personagem_fk1] FOREIGN KEY ([idPersonagem]) REFERENCES [Personagem]([idPersonagem])
ON UPDATE CASCADE
GO
ALTER TABLE [Item_Personagem] CHECK CONSTRAINT [Item_Personagem_fk1]
GO

ALTER TABLE [Item_Historia] WITH CHECK ADD CONSTRAINT [Item_Historia_fk0] FOREIGN KEY ([idHistoria]) REFERENCES [Historia]([idHistoria])
ON UPDATE CASCADE
GO
ALTER TABLE [Item_Historia] CHECK CONSTRAINT [Item_Historia_fk0]
GO
ALTER TABLE [Item_Historia] WITH CHECK ADD CONSTRAINT [Item_Historia_fk1] FOREIGN KEY ([idItem]) REFERENCES [Item]([idItem])
ON UPDATE CASCADE
GO
ALTER TABLE [Item_Historia] CHECK CONSTRAINT [Item_Historia_fk1]
GO

