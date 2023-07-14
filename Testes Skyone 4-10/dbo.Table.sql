CREATE TABLE [dbo].[Alunos-Notas] (
    [Aluno] VARCHAR (50) NOT NULL,
    [Semestre1] INT NOT NULL,
    [Semestre2] INT NOT NULL,
    [Media_Anual] INT NOT NULL,
    [Status] VARCHAR (50) NOT NULL,
    [Ano] INT DEFAULT YEAR(GETDATE()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Aluno], [Ano] ASC)
);
