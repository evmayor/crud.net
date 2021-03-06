USE [Ejemplo]
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 06/11/2018 07:40:37 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[Curso_id] [int] NOT NULL,
	[Curso_nombre] [nvarchar](100) NULL,
	[Curso_creditos] [int] NULL,
	[Curso_codicion] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Curso_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Curso] ([Curso_id], [Curso_nombre], [Curso_creditos], [Curso_codicion]) VALUES (0, N'C#', 3, 1)
INSERT [dbo].[Curso] ([Curso_id], [Curso_nombre], [Curso_creditos], [Curso_codicion]) VALUES (1, N'VB', 2, 1)
INSERT [dbo].[Curso] ([Curso_id], [Curso_nombre], [Curso_creditos], [Curso_codicion]) VALUES (2, N'ASP 2', 3, 1)
INSERT [dbo].[Curso] ([Curso_id], [Curso_nombre], [Curso_creditos], [Curso_codicion]) VALUES (3, N'PYTHON', 4, 0)
INSERT [dbo].[Curso] ([Curso_id], [Curso_nombre], [Curso_creditos], [Curso_codicion]) VALUES (4, N'PHP', 2, 1)
INSERT [dbo].[Curso] ([Curso_id], [Curso_nombre], [Curso_creditos], [Curso_codicion]) VALUES (5, N'Redes3', 4, 1)
INSERT [dbo].[Curso] ([Curso_id], [Curso_nombre], [Curso_creditos], [Curso_codicion]) VALUES (6, N'Angular', 4, 1)
INSERT [dbo].[Curso] ([Curso_id], [Curso_nombre], [Curso_creditos], [Curso_codicion]) VALUES (7, N'Django', 2, 1)
INSERT [dbo].[Curso] ([Curso_id], [Curso_nombre], [Curso_creditos], [Curso_codicion]) VALUES (8, N'sql server', 3, 0)
/****** Object:  StoredProcedure [dbo].[_spDelete]    Script Date: 06/11/2018 07:40:37 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[_spDelete](@curso_id int)
as
begin 
	update Curso
	set Curso_codicion = 0 where Curso_id = @curso_id
	select * from Curso where Curso_codicion = 1
end
GO
/****** Object:  StoredProcedure [dbo].[_spInsert]    Script Date: 06/11/2018 07:40:37 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[_spInsert](@curso_nombre nvarchar(100),@curso_creditos int)
as
begin 
	declare @id int 
	set @id = (select MAX(Curso_id) from Curso)
	if (@id is null)
		set @id = 0
	else
		set @id = (select MAX(Curso_id) from Curso) + 1
	
	insert into Curso(Curso_id,Curso_nombre,Curso_creditos,curso_codicion) values (@id, @curso_nombre, @curso_creditos,1)
	select * from Curso where Curso_codicion = 1

end
GO
/****** Object:  StoredProcedure [dbo].[_spRead]    Script Date: 06/11/2018 07:40:37 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[_spRead]
as
select Curso_id, Curso_nombre,Curso_creditos from Curso where Curso_codicion = 1
GO
/****** Object:  StoredProcedure [dbo].[_spUpdate]    Script Date: 06/11/2018 07:40:37 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[_spUpdate](@curso_id int,@curso_nombre nvarchar(100),@curso_creditos int)
as
begin
	update Curso
	set Curso_nombre = @curso_nombre, Curso_creditos = @curso_creditos
	where Curso_id = @curso_id
	select * from Curso where Curso_codicion = 1
end
GO
