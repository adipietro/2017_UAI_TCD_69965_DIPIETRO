USE [master]
GO
/****** Object:  Database [Productos y Proveedores]    Script Date: 7/5/2017 6:38:10 p. m. ******/
CREATE DATABASE [Productos y Proveedores]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Productos y Proveedores', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Productos y Proveedores.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Productos y Proveedores_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Productos y Proveedores_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Productos y Proveedores] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Productos y Proveedores].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Productos y Proveedores] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Productos y Proveedores] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Productos y Proveedores] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Productos y Proveedores] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Productos y Proveedores] SET ARITHABORT OFF 
GO
ALTER DATABASE [Productos y Proveedores] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Productos y Proveedores] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Productos y Proveedores] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Productos y Proveedores] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Productos y Proveedores] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Productos y Proveedores] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Productos y Proveedores] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Productos y Proveedores] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Productos y Proveedores] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Productos y Proveedores] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Productos y Proveedores] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Productos y Proveedores] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Productos y Proveedores] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Productos y Proveedores] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Productos y Proveedores] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Productos y Proveedores] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Productos y Proveedores] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Productos y Proveedores] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Productos y Proveedores] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Productos y Proveedores] SET  MULTI_USER 
GO
ALTER DATABASE [Productos y Proveedores] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Productos y Proveedores] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Productos y Proveedores] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Productos y Proveedores] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Productos y Proveedores]
GO
/****** Object:  StoredProcedure [dbo].[AltaFamilia]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AltaFamilia] (@nom as varchar(60),@id as int)

AS
BEGIN

insert into Familias (Nombre,Id_Familia  ) values (@nom,@id )


END
GO
/****** Object:  StoredProcedure [dbo].[AltaGRPPatentes]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AltaGRPPatentes] (@nom as varchar(60),@id as int, @padre as int)

AS
BEGIN

insert into GrupoPatentes (Nombre, ID_GrupoPatente, Padre) values (@nom, @padre,@id )

END
GO
/****** Object:  StoredProcedure [dbo].[AltaPatentes]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AltaPatentes] (@nom as varchar(60),@id as int, @padre as int, @form as varchar(50))

AS
BEGIN

insert into Patentes (Nombre, ID_Patente, Padre, Formulario) values (@nom, @padre, @form,@id )

END
GO
/****** Object:  StoredProcedure [dbo].[AltaProductos]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AltaProductos] (@nom as varchar(60),@id as int, @Frec as int)

AS
BEGIN

insert into prodProductos (Nombre, id_Productos, Frecuencia) values (@nom, @frec,@id )

END
GO
/****** Object:  StoredProcedure [dbo].[AltaProveedores]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AltaProveedores] (@nom as varchar(60),@id as int, @dir as varchar(50), @tel as varchar(50), @correo as varchar(50))

AS
BEGIN

insert into Proveedores(Nombre, id_Proveedor, Direccion, Telefono, [Correo Electronico]) values (@nom ,@id, @dir, @tel , @correo)

END
GO
/****** Object:  StoredProcedure [dbo].[AltaUsuario]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AltaUsuario] (@nom as varchar(50),@ape as varchar (50) ,@uss as varchar(50), @contraseña as varchar(50),@id as int)

AS
BEGIN

insert into Usuarios (Nombre,Apellido,usuario,Contraseña, Id_Uss      ) values (@nom,@ape,@uss  ,@contraseña,@id )


END
GO
/****** Object:  StoredProcedure [dbo].[BuscarFamilia]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuscarFamilia]

AS
BEGIN

select * from Familias 

END

GO
/****** Object:  StoredProcedure [dbo].[BuscarGRPPatente]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuscarGRPPatente]

AS
BEGIN

select * from GrupoPatentes

END
GO
/****** Object:  StoredProcedure [dbo].[BuscarPatente]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuscarPatente]

AS
BEGIN

select * from Patentes

END

GO
/****** Object:  StoredProcedure [dbo].[BuscarUsuario]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuscarUsuario]

AS
BEGIN

select * from Usuarios 

END

GO
/****** Object:  StoredProcedure [dbo].[EliminarFamilia]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarFamilia] (@id as int )
AS
BEGIN


delete from Familias  where ID_Familia   = @id 


END
GO
/****** Object:  StoredProcedure [dbo].[EliminarGRPPatente]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarGRPPatente] (@id as int )
AS
BEGIN


delete from GrupoPatentes  where Id_GrupoPatente   = @id 


END
GO
/****** Object:  StoredProcedure [dbo].[EliminarPatente]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[EliminarPatente] (@id as int )
AS
BEGIN


delete from Patentes  where ID_Patente   = @id 


END
GO
/****** Object:  StoredProcedure [dbo].[EliminarUsuario]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarUsuario] (@id as int )
AS
BEGIN


delete from Usuarios where ID_UsS  = @id 


END
GO
/****** Object:  StoredProcedure [dbo].[ListarFamilia]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarFamilia]



AS
BEGIN

select * from Familias 

END
GO
/****** Object:  StoredProcedure [dbo].[ListarGRPPatentes]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarGRPPatentes]



AS
BEGIN

select * from GrupoPatentes

END
GO
/****** Object:  StoredProcedure [dbo].[ListarPatentes]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarPatentes]



AS
BEGIN

select * from Patentes

END
GO
/****** Object:  StoredProcedure [dbo].[ListarUsuarios]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[ListarUsuarios]



AS
BEGIN

select * from Usuarios 

END

GO
/****** Object:  StoredProcedure [dbo].[ModificarFamilia]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarFamilia] (@id as int, @nom as varchar (60))

AS
BEGIN

update Familias

set

Nombre = @nom
where ID_Familia  = @id 


END
GO
/****** Object:  StoredProcedure [dbo].[ModificarGRPPatente]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarGRPPatente] (@id as int, @padre as varchar (60) , @nom as varchar (60))

AS
BEGIN

update GrupoPatentes

set

Nombre = @nom,
Padre = @padre  

where Id_GrupoPatente= @id 


END
GO
/****** Object:  StoredProcedure [dbo].[ModificarPatente]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarPatente] (@id as int, @padre as varchar (60) , @nom as varchar (60))

AS
BEGIN

update Patentes

set

Nombre = @nom,
Padre = @padre  

where ID_Patente = @id 


END
GO
/****** Object:  StoredProcedure [dbo].[ModificarUsuario]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarUsuario] (@id as int, @nom as varchar (60) , @ape as varchar (60) , @Contraseña as varchar(50))

AS
BEGIN

update Usuarios

set

Nombre = @nom,
Apellido = @ape ,
Contraseña =  @Contraseña  
where Id_Uss  = @id 


END
GO
/****** Object:  StoredProcedure [dbo].[ProxIdFamilia]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProxIdFamilia]

AS
BEGIN

select max (ID_Familia) + 1 from Familias 

END
GO
/****** Object:  StoredProcedure [dbo].[ProxIdGRPPatente]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProxIdGRPPatente]

AS
BEGIN

select max (Id_GrupoPatente  ) + 1 from GrupoPatentes 

END
GO
/****** Object:  StoredProcedure [dbo].[ProxIdPatente]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProxIdPatente]

AS
BEGIN

select max (ID_Patente ) + 1 from Patentes

END

GO
/****** Object:  StoredProcedure [dbo].[ProxIdUsuario]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProxIdUsuario]

AS
BEGIN

select max (Id_Uss ) + 1 from Usuarios

END
GO
/****** Object:  Table [dbo].[Familias]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Familias](
	[ID_Familia] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GrupoPatentes]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GrupoPatentes](
	[Id_GrupoPatente] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Padre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Componenetes] PRIMARY KEY CLUSTERED 
(
	[Id_GrupoPatente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Patentes]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Patentes](
	[ID_Patente] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Padre] [int] NOT NULL,
	[Formulario] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Patentes] PRIMARY KEY CLUSTERED 
(
	[ID_Patente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Productos](
	[ID_Productos] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Frecuencia] [varchar](50) NOT NULL,
	[Proveedor Seleccionado] [int] NOT NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[ID_Productos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[ID_Proveedor] [int] NOT NULL,
	[Nombre] [nchar](10) NOT NULL,
	[Direccion] [nchar](10) NOT NULL,
	[Telefono] [nchar](10) NOT NULL,
	[Correo Electronico] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[ID_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 7/5/2017 6:38:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id_Uss] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id_Uss] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Proveedores]  WITH CHECK ADD  CONSTRAINT [FK_Proveedores_Productos] FOREIGN KEY([ID_Proveedor])
REFERENCES [dbo].[Productos] ([ID_Productos])
GO
ALTER TABLE [dbo].[Proveedores] CHECK CONSTRAINT [FK_Proveedores_Productos]
GO
USE [master]
GO
ALTER DATABASE [Productos y Proveedores] SET  READ_WRITE 
GO
