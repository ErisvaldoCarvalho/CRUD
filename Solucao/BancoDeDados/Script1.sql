﻿SET NOCOUNT ON

USE MASTER
GO

IF NOT EXISTS(SELECT 1 FROM SYSDATABASES WHERE NAME LIKE 'ModelagemRapida')
	CREATE DATABASE ModelagemRapida
GO

USE ModelagemRapida
GO

IF EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'ColunasPadroes')
	DROP TABLE ColunasPadroes

IF NOT EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'ColunasPadroes')
BEGIN
	CREATE TABLE ColunasPadroes (ID INT PRIMARY KEY IDENTITY(1, 1))
END

IF NOT EXISTS (SELECT 1 FROM SYS.OBJECTS T INNER JOIN SYS.COLUMNS C ON T.OBJECT_ID = C.OBJECT_ID WHERE T.NAME = 'ColunasPadroes' AND C.NAME = 'SCRIPT')
BEGIN
	ALTER TABLE ColunasPadroes ADD SCRIPT VARCHAR(150)
END

IF NOT EXISTS (SELECT 1 FROM SYS.OBJECTS T INNER JOIN SYS.COLUMNS C ON T.OBJECT_ID = C.OBJECT_ID WHERE T.NAME = 'ColunasPadroes' AND C.NAME = 'Coluna')
BEGIN
	ALTER TABLE ColunasPadroes ADD Coluna VARCHAR(150)
END

IF NOT EXISTS (SELECT 1 FROM SYS.OBJECTS T INNER JOIN SYS.COLUMNS C ON T.OBJECT_ID = C.OBJECT_ID WHERE T.NAME = 'ColunasPadroes' AND C.NAME = 'Tipo')
BEGIN
	ALTER TABLE ColunasPadroes ADD Tipo VARCHAR(150)
END

IF NOT EXISTS (SELECT 1 FROM SYS.OBJECTS T INNER JOIN SYS.COLUMNS C ON T.OBJECT_ID = C.OBJECT_ID WHERE T.NAME = 'ColunasPadroes' AND C.NAME = 'Primeira')
BEGIN
	ALTER TABLE ColunasPadroes ADD Primeira BIT
END

INSERT INTO ColunasPadroes(SCRIPT, Coluna, Tipo, Primeira) VALUES('CREATE TABLE @Tabela (@Coluna @Tipo)', 'ID', 'FLOAT PRIMARY KEY', 1)
INSERT INTO ColunasPadroes(SCRIPT, Coluna, Tipo, Primeira) VALUES('ALTER TABLE @Tabela ADD @Coluna @Tipo', 'ID_Entidade', 'FLOAT', 1)
INSERT INTO ColunasPadroes(SCRIPT, Coluna, Tipo, Primeira) VALUES('ALTER TABLE @Tabela ADD @Coluna @Tipo', 'ID_BancoDeDados', 'FLOAT', 1)
INSERT INTO ColunasPadroes(SCRIPT, Coluna, Tipo, Primeira) VALUES('ALTER TABLE @Tabela ADD @Coluna @Tipo', 'Ativo', 'FLOAT', 0)
INSERT INTO ColunasPadroes(SCRIPT, Coluna, Tipo, Primeira) VALUES('ALTER TABLE @Tabela ADD @Coluna @Tipo', 'ID_UsuarioCadastro', 'FLOAT', 0)
INSERT INTO ColunasPadroes(SCRIPT, Coluna, Tipo, Primeira) VALUES('ALTER TABLE @Tabela ADD @Coluna @Tipo', 'ID_UsuarioAlteracao', 'FLOAT', 0)
INSERT INTO ColunasPadroes(SCRIPT, Coluna, Tipo, Primeira) VALUES('ALTER TABLE @Tabela ADD @Coluna @Tipo', 'DataCadastro', 'DATETIME', 0)
INSERT INTO ColunasPadroes(SCRIPT, Coluna, Tipo, Primeira) VALUES('ALTER TABLE @Tabela ADD @Coluna @Tipo', 'DataAlteracao', 'DATETIME', 0)


IF EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'SP_AdicionarColuna')
	DROP PROC SP_AdicionarColuna
GO

IF EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'SP_RemoverUltimasColunasPadroes')
	DROP PROC SP_RemoverUltimasColunasPadroes
GO

IF EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'SP_AdicionarPrimeirasColunasPadroes')
	DROP PROC SP_AdicionarPrimeirasColunasPadroes
GO

IF EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = 'SP_AdicionarUltimasColunasPadroes')
	DROP PROC SP_AdicionarUltimasColunasPadroes
GO

CREATE PROC SP_RemoverUltimasColunasPadroes
	@Tabela VARCHAR(200)
AS
	DECLARE @SQL VARCHAR(MAX)
	
	WHILE EXISTS(SELECT 1 FROM SYS.OBJECTS T INNER JOIN SYS.COLUMNS C ON T.OBJECT_ID = C.OBJECT_ID 
		WHERE T.NAME = @Tabela AND C.NAME IN(SELECT Coluna FROM ColunasPadroes WHERE Primeira = 0))
	BEGIN
		SET @SQL = (SELECT TOP 1 'ALTER TABLE ' + @Tabela + ' DROP COLUMN ' + C.name FROM SYS.OBJECTS T INNER JOIN SYS.COLUMNS C ON T.OBJECT_ID = C.OBJECT_ID 
					WHERE T.NAME = @Tabela AND C.NAME IN(SELECT Coluna FROM ColunasPadroes WHERE Primeira = 0))
		
		PRINT @SQL
		
		EXEC @SQL
	END
	PRINT @SQL
	
GO

CREATE PROC SP_AdicionarPrimeirasColunasPadroes
	@Tabela VARCHAR(200)
AS
	DECLARE @SQL VARCHAR(MAX)
	DECLARE @ID FLOAT
	DECLARE @Coluna VARCHAR(150)
	DECLARE @Tipo VARCHAR(150)
	DECLARE @Pre VARCHAR(400)

	WHILE (EXISTS(SELECT 1 FROM ColunasPadroes WHERE Primeira = 1 AND COLUNA NOT IN(SELECT C.NAME FROM SYS.OBJECTS T INNER JOIN SYS.COLUMNS C ON T.OBJECT_ID = C.OBJECT_ID WHERE T.NAME = @Tabela)))
	BEGIN
		SET @ID = (SELECT MIN(ID) FROM ColunasPadroes WHERE Primeira = 1 AND COLUNA NOT IN(SELECT C.NAME FROM SYS.OBJECTS T INNER JOIN SYS.COLUMNS C ON T.OBJECT_ID = C.OBJECT_ID WHERE T.NAME = @Tabela))			
		
		SET @SQL = (SELECT REPLACE(REPLACE(REPLACE(SCRIPT, '@Tabela', @Tabela), '@Coluna', Coluna), '@Tipo', Tipo) FROM ColunasPadroes WHERE ID = @ID)
		PRINT @SQL
		EXEC (@SQL)
	END
GO


CREATE PROC SP_AdicionarUltimasColunasPadroes
	@Tabela VARCHAR(200)
AS
	DECLARE @SQL VARCHAR(MAX)
	DECLARE @ID FLOAT
	DECLARE @Coluna VARCHAR(150)
	DECLARE @Tipo VARCHAR(150)
	DECLARE @Pre VARCHAR(400)

	WHILE (EXISTS(SELECT 1 FROM ColunasPadroes WHERE Primeira = 0 AND COLUNA NOT IN(SELECT C.NAME FROM SYS.OBJECTS T INNER JOIN SYS.COLUMNS C ON T.OBJECT_ID = C.OBJECT_ID WHERE T.NAME = @Tabela)))
	BEGIN
		SET @ID = (SELECT MIN(ID) FROM ColunasPadroes WHERE Primeira = 0 AND COLUNA NOT IN(SELECT C.NAME FROM SYS.OBJECTS T INNER JOIN SYS.COLUMNS C ON T.OBJECT_ID = C.OBJECT_ID WHERE T.NAME = @Tabela))			
		
		SET @SQL = (SELECT REPLACE(REPLACE(REPLACE(SCRIPT, '@Tabela', @Tabela), '@Coluna', Coluna), '@Tipo', Tipo) FROM ColunasPadroes WHERE ID = @ID)
		PRINT @SQL
		EXEC (@SQL)
	END
GO

CREATE PROC SP_AdicionarColuna
	@Tabela VARCHAR(250),
	@Campo VARCHAR(250) = NULL,
	@Tipo VARCHAR(250) = 'VARCHAR(150)'
AS

DECLARE @SQL VARCHAR(MAX)

IF @Campo IS NULL
BEGIN
	EXEC SP_AdicionarPrimeirasColunasPadroes @Tabela
	SET @Campo = 'Descricao'
END

	EXEC SP_AdicionarUltimasColunasPadroes @Tabela
GO

SELECT*FROM TESTE
GO
DROP TABLE TESTE
EXEC SP_AdicionarColuna 'TESTE'
