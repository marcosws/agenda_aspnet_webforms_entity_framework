
/* =========== Exclui Tabelas, Chaves Primarias/Extrangeira ========== */

IF (OBJECT_ID('fk_contatos', 'F') IS NOT NULL)
BEGIN
    ALTER TABLE dbo.Contatos DROP CONSTRAINT fk_contatos
END
GO

IF (OBJECT_ID('pk_contatos', 'PK') IS NOT NULL)
BEGIN
    ALTER TABLE dbo.Contatos DROP CONSTRAINT pk_contatos
END
GO

IF (OBJECT_ID('pk_usuarios', 'PK') IS NOT NULL)
BEGIN
    ALTER TABLE dbo.Usuarios DROP CONSTRAINT pk_usuarios
END
GO

IF OBJECT_ID('dbo.Usuarios', 'U') IS NOT NULL DROP TABLE dbo.Usuarios;
IF OBJECT_ID('dbo.Contatos', 'U') IS NOT NULL DROP TABLE dbo.Contatos;

/* ============ Cria as Tabelas =============================== */

CREATE TABLE Usuarios(
Id INT IDENTITY(1,1) CONSTRAINT pk_usuarios PRIMARY KEY (Id),
Nome VARCHAR(255) NOT NULL,
Email VARCHAR(255) UNIQUE,
Senha VARCHAR(255)
);

CREATE TABLE Contatos(
Id INT IDENTITY(1,1) CONSTRAINT pk_contatos  PRIMARY KEY (Id),
UsuarioId INTEGER CONSTRAINT fk_contatos 
FOREIGN KEY (UsuarioId) 
REFERENCES usuarios (Id) 
ON DELETE CASCADE,
Nome VARCHAR(255),
Cpf VARCHAR(15),
Telefone VARCHAR(15),
Email VARCHAR(100),
Site VARCHAR(100),
);

/* ===============================================================*/

INSERT INTO Usuarios VALUES(
'Marcos Souza',
'marcos@gmail.com',
'marcos'
);

INSERT INTO Usuarios VALUES(
'José Santos',
'jose.sn@bol.com.br',
'jose'
);

INSERT INTO Usuarios VALUES(
'Valter Silva',
'valter@valtersv.net',
'valter'
);

INSERT INTO Contatos VALUES (
1,
'Marcos Souza',
'22298559309',
'39160711',
'marcos@yahoo.com.br',
'www.mws.com'
);

INSERT INTO Contatos VALUES (
1,
'Mara Santos',
'84827759790',
'39000711',
'mara@ymail.com',
'www.marasantos.com'
);

INSERT INTO Contatos VALUES (
1,
'Roberto Correia',
'94364125334',
'39000000','robcorreia@bol.com.br',
'www.robcor.net'
);

INSERT INTO Contatos VALUES (
2,
'Aline Mansur',
'40496530798',
'38887710',
'aline.mansur@mansurgroup.com',
'www.alinemansur.com'
);

INSERT INTO Contatos VALUES (
2,
'Vanessa Braga dos Santos',
'71129512754',
'37786770',
'vanbraga@hotmail.com',
'www.webper.com\vanbraga'
);

INSERT INTO Contatos VALUES (
3,
'Julio Mattos',
'58529213513',
'39110990',
'juliomattos@ymail.com',
'www.juliom.com.br'
);