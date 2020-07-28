CREATE TABLE [dbo].[RT_Escola](
	[RT_Escola_ID] [uniqueidentifier] NOT NULL DEFAULT (newid()),
	[Nome] [varchar](300) NOT NULL,
	[Endereco] [varchar](1000) NULL,
 CONSTRAINT [RT_Escola_PK] PRIMARY KEY CLUSTERED 
(
	[RT_Escola_ID] ASC
) ON [PRIMARY]
)
GO
CREATE TABLE [dbo].[RT_Turma](
	[RT_Turma_ID] [uniqueidentifier] NOT NULL DEFAULT (newid()),
	[RT_Escola_ID] [uniqueidentifier] NOT NULL,
	[Nome] [varchar](300) NOT NULL
 CONSTRAINT [RT_Turma_PK] PRIMARY KEY CLUSTERED 
(
	[RT_Turma_ID] ASC
) ON [PRIMARY]
)
GO
ALTER TABLE [dbo].[RT_Turma]  WITH CHECK ADD  CONSTRAINT [RT_Turma_RT_Escola_FK] FOREIGN KEY([RT_Escola_ID])
REFERENCES [dbo].[RT_Escola] ([RT_Escola_ID])
GO
CREATE TABLE [dbo].[RT_Aluno](
	[RT_Aluno_ID] [uniqueidentifier] NOT NULL DEFAULT (newid()),
	[Nome] [varchar](1000) NOT NULL,
 CONSTRAINT [RT_Aluno_PK] PRIMARY KEY CLUSTERED 
(
	[RT_Aluno_ID] ASC
) ON [PRIMARY]
)
GO
CREATE TABLE [dbo].[RE_AlunoTurma](
	[RE_AlunoTurma_ID] [uniqueidentifier] NOT NULL DEFAULT (newid()),
	[RT_Aluno_ID] [uniqueidentifier] NOT NULL,
	[RT_Turma_ID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [RT_AlunoTurma_PK] PRIMARY KEY CLUSTERED 
(
	[RE_AlunoTurma_ID] ASC
) ON [PRIMARY]
)
GO
ALTER TABLE [dbo].[RE_AlunoTurma]  WITH CHECK ADD  CONSTRAINT [RT_AlunoTurma_RT_Aluno_FK] FOREIGN KEY([RT_Aluno_ID])
REFERENCES [dbo].[RT_Aluno] ([RT_Aluno_ID])
GO
ALTER TABLE [dbo].[RE_AlunoTurma]  WITH CHECK ADD  CONSTRAINT [RT_AlunoTurma_RT_Turma_FK] FOREIGN KEY([RT_Turma_ID])
REFERENCES [dbo].[RT_Turma] ([RT_Turma_ID])