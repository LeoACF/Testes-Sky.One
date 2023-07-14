CREATE TABLE [dbo].[Alunos] (
    [Nome_aluno]  VARCHAR (50) NOT NULL,
    [Nota1]      INT          NOT NULL,
    [Nota2]      INT          NOT NULL,
    [Media_Anual] INT          NOT NULL,
    [Status]      VARCHAR (50) NOT NULL,
    [Ano]         DATETIME     DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Nome_aluno] ASC)
);
