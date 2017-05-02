CREATE TABLE [dbo].[Teste]
(
	[Id] FLOAT NOT NULL PRIMARY KEY, 
    [Id_Entidade] FLOAT NULL, 
    [Id_Banco] FLOAT NULL, 
    [Descricao] VARCHAR(200) NULL, 
    [DataCadastro] DATETIME NULL DEFAULT getdate()
)
