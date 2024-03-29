/****** Object:  Database [fedra-dev]    Script Date: 7/8/2023 4:02:12 PM ******/
CREATE DATABASE [fedra-dev]  (EDITION = 'GeneralPurpose', SERVICE_OBJECTIVE = 'GP_S_Gen5_1', MAXSIZE = 32 GB) WITH CATALOG_COLLATION = SQL_Latin1_General_CP1_CI_AS, LEDGER = OFF;
GO
ALTER DATABASE [fedra-dev] SET COMPATIBILITY_LEVEL = 150
GO
ALTER DATABASE [fedra-dev] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [fedra-dev] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [fedra-dev] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [fedra-dev] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [fedra-dev] SET ARITHABORT OFF 
GO
ALTER DATABASE [fedra-dev] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [fedra-dev] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [fedra-dev] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [fedra-dev] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [fedra-dev] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [fedra-dev] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [fedra-dev] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [fedra-dev] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [fedra-dev] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [fedra-dev] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [fedra-dev] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [fedra-dev] SET  MULTI_USER 
GO
ALTER DATABASE [fedra-dev] SET ENCRYPTION ON
GO
ALTER DATABASE [fedra-dev] SET QUERY_STORE = ON
GO
ALTER DATABASE [fedra-dev] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 100, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
/*** The scripts of database scoped configurations in Azure should be executed inside the target database connection. ***/
GO
-- ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 8;
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 7/8/2023 4:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](250) NULL,
	[EmpresaId] [bigint] NULL,
	[Estado] [int] NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoriasComprobantes]    Script Date: 7/8/2023 4:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoriasComprobantes](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](255) NULL,
	[TipoConfiguracionDocumentoId] [bigint] NULL,
 CONSTRAINT [PK_CategoriasComprobantes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comprobantes]    Script Date: 7/8/2023 4:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comprobantes](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Consecutivo] [bigint] NULL,
	[Descripcion] [varchar](500) NULL,
	[Valor] [decimal](18, 0) NULL,
	[TerceroId] [bigint] NULL,
	[CategoriaComprobanteId] [bigint] NULL,
	[DocumentoId] [bigint] NULL,
	[TipoConfiguracionDocumentoId] [bigint] NULL,
	[EmpresaId] [bigint] NULL,
	[FormaPagoId] [bigint] NULL,
	[ReferenciaPago] [varchar](50) NULL,
	[Estado] [int] NULL,
	[CreadoPor] [varchar](50) NOT NULL,
	[FechaCreacion] [datetime2](7) NOT NULL,
	[ModificadoPor] [varchar](50) NOT NULL,
	[FechaModificacion] [datetime2](7) NULL,
 CONSTRAINT [PK_Comprobantes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CondicionesPago]    Script Date: 7/8/2023 4:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CondicionesPago](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[PlazoDias] [int] NULL,
	[EmpresaId] [bigint] NULL,
 CONSTRAINT [PK_CondicionesPago] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConfiguracionDocumentos]    Script Date: 7/8/2023 4:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConfiguracionDocumentos](
	[Id] [bigint] NULL,
	[EmpresaId] [bigint] NULL,
	[NombreDocumento] [varchar](100) NULL,
	[Codigo] [varchar](5) NULL,
	[Prefijo] [varchar](50) NULL,
	[Sufijo] [varchar](50) NULL,
	[AfectaInventario] [bit] NULL,
	[ConsecutivoInicial] [bigint] NULL,
	[ConsecutivoActual] [bigint] NULL,
	[ConsecutivoFinal] [bigint] NULL,
	[Mensaje] [text] NULL,
	[Mensaje2] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamentos]    Script Date: 7/8/2023 4:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamentos](
	[Id] [bigint] NOT NULL,
	[Descripcion] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Departamentos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Documentos]    Script Date: 7/8/2023 4:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Documentos](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[TipoConfiguracionDocumentoId] [bigint] NULL,
	[CodigoBarras] [varchar](50) NULL,
	[Consecutivo] [bigint] NULL,
	[TerceroId] [bigint] NULL,
	[Fecha] [datetime2](7) NULL,
	[FechaVencimiento] [datetime2](7) NULL,
	[Subtotal] [decimal](18, 0) NULL,
	[Ajuste] [decimal](18, 0) NULL,
	[Descuento] [decimal](18, 0) NULL,
	[Total] [decimal](18, 0) NULL,
	[Estado] [int] NULL,
	[EmpresaId] [bigint] NULL,
	[Condicion] [int] NULL,
	[FormaPagoId] [bigint] NULL,
	[Referencia] [varchar](255) NULL,
	[DineroRecibido] [decimal](18, 0) NULL,
	[Cambio] [decimal](18, 0) NULL,
	[CreadoPor] [varchar](50) NOT NULL,
	[FechaCreacion] [datetime2](7) NOT NULL,
	[ModificadoPor] [varchar](50) NOT NULL,
	[FechaModificacion] [datetime2](7) NULL,
 CONSTRAINT [PK_Documentos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocumentosImpuestosTotales]    Script Date: 7/8/2023 4:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentosImpuestosTotales](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[DocumentoId] [bigint] NULL,
	[ImpuestoId] [bigint] NULL,
	[Valor] [decimal](18, 0) NULL,
 CONSTRAINT [PK_DocumentosImpuestosTotales] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocumentosProductos]    Script Date: 7/8/2023 4:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentosProductos](
	[Id] [bigint] NOT NULL,
	[DocumentoId] [bigint] NULL,
	[ProductoId] [bigint] NULL,
	[Cantidad] [decimal](18, 0) NULL,
	[ValorUnitario] [decimal](18, 0) NULL,
	[Descuento] [decimal](18, 0) NULL,
	[Total] [nchar](10) NULL,
 CONSTRAINT [PK_DocumentosProductos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocumentosProductosImpuestos]    Script Date: 7/8/2023 4:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentosProductosImpuestos](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[DocumentoProductoId] [bigint] NULL,
	[ImpuestoId] [bigint] NULL,
	[Valor] [decimal](18, 0) NULL,
 CONSTRAINT [PK_DocumentosProductosImpuestos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empresas]    Script Date: 7/8/2023 4:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresas](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Nit] [varchar](50) NULL,
	[Direccion] [varchar](255) NULL,
	[Telefonos] [varchar](255) NULL,
 CONSTRAINT [PK_Empresas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exenciones]    Script Date: 7/8/2023 4:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exenciones](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[TerceroId] [bigint] NULL,
	[ProductoId] [bigint] NULL,
	[ImpuestoId] [bigint] NULL,
	[Observacion] [varchar](255) NULL,
 CONSTRAINT [PK_Exenciones] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormasPago]    Script Date: 7/8/2023 4:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormasPago](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](255) NOT NULL,
 CONSTRAINT [PK_FormasPago] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Impuestos]    Script Date: 7/8/2023 4:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Impuestos](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[EmpresaId] [bigint] NULL,
	[Descripcion] [varchar](50) NULL,
	[Porcentaje] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Impuestos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Municipios]    Script Date: 7/8/2023 4:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Municipios](
	[Id] [bigint] NOT NULL,
	[Descripcion] [varchar](250) NOT NULL,
	[DepartamentoId] [bigint] NOT NULL,
 CONSTRAINT [PK_Municipios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 7/8/2023 4:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](100) NULL,
	[CodigoBarras] [varchar](100) NULL,
	[Nombre] [varchar](500) NOT NULL,
	[UnidadMedidaId] [bigint] NULL,
	[CategoriaId] [bigint] NULL,
	[CostoPonderado] [decimal](18, 0) NULL,
	[PrecioVenta] [decimal](18, 0) NULL,
	[StockMinimo] [int] NULL,
	[StockActual] [int] NULL,
	[StockMaximo] [int] NULL,
	[Ubicacion] [varchar](500) NULL,
	[EmpresaId] [bigint] NOT NULL,
	[Estado] [int] NULL,
	[CreadoPor] [varchar](50) NOT NULL,
	[FechaCreacion] [datetime2](7) NOT NULL,
	[ModificadoPor] [varchar](50) NOT NULL,
	[FechaModificacion] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Terceros]    Script Date: 7/8/2023 4:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Terceros](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[EmpresaId] [bigint] NOT NULL,
	[TipoIdentificacionId] [bigint] NOT NULL,
	[Numero] [varchar](50) NOT NULL,
	[Tipo] [int] NOT NULL,
	[Nombre] [varchar](255) NOT NULL,
	[Direccion] [varchar](255) NULL,
	[Celular] [varchar](50) NULL,
	[Telefono] [varchar](255) NULL,
	[Email] [varchar](100) NULL,
	[DepartamentoId] [bigint] NULL,
	[MunicipioId] [bigint] NULL,
	[Calificacion] [int] NULL,
	[Observaciones] [text] NULL,
	[Estado] [int] NOT NULL,
	[CreadoPor] [varchar](50) NOT NULL,
	[FechaCreacion] [datetime2](7) NOT NULL,
	[ModificadoPor] [varchar](50) NOT NULL,
	[FechaModificacion] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Terceros] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposIdentificacion]    Script Date: 7/8/2023 4:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposIdentificacion](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TiposIdentificacion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnidadesMedida]    Script Date: 7/8/2023 4:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnidadesMedida](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Simbolo] [varchar](50) NULL,
	[Nombre] [varchar](255) NULL,
 CONSTRAINT [PK_UnidadesMedida] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categorias] ON 

INSERT [dbo].[Categorias] ([Id], [Descripcion], [EmpresaId], [Estado]) VALUES (1, N'GENERAL', 1, 1)
SET IDENTITY_INSERT [dbo].[Categorias] OFF
GO
SET IDENTITY_INSERT [dbo].[Comprobantes] ON 

INSERT [dbo].[Comprobantes] ([Id], [Consecutivo], [Descripcion], [Valor], [TerceroId], [CategoriaComprobanteId], [DocumentoId], [TipoConfiguracionDocumentoId], [EmpresaId], [FormaPagoId], [ReferenciaPago], [Estado], [CreadoPor], [FechaCreacion], [ModificadoPor], [FechaModificacion]) VALUES (3, 1, N'string', CAST(1121 AS Decimal(18, 0)), NULL, NULL, NULL, 1, 1, NULL, N'string', 1, N'string', CAST(N'2023-07-08T15:13:21.2919770' AS DateTime2), N'string', CAST(N'2023-07-08T15:13:21.2914504' AS DateTime2))
INSERT [dbo].[Comprobantes] ([Id], [Consecutivo], [Descripcion], [Valor], [TerceroId], [CategoriaComprobanteId], [DocumentoId], [TipoConfiguracionDocumentoId], [EmpresaId], [FormaPagoId], [ReferenciaPago], [Estado], [CreadoPor], [FechaCreacion], [ModificadoPor], [FechaModificacion]) VALUES (4, 1, N'string', CAST(1121 AS Decimal(18, 0)), NULL, NULL, NULL, 1, 1, NULL, N'string', 1, N'string', CAST(N'2023-07-08T15:15:29.2942169' AS DateTime2), N'string', CAST(N'2023-07-08T15:15:29.2936090' AS DateTime2))
INSERT [dbo].[Comprobantes] ([Id], [Consecutivo], [Descripcion], [Valor], [TerceroId], [CategoriaComprobanteId], [DocumentoId], [TipoConfiguracionDocumentoId], [EmpresaId], [FormaPagoId], [ReferenciaPago], [Estado], [CreadoPor], [FechaCreacion], [ModificadoPor], [FechaModificacion]) VALUES (5, 1, N'string', CAST(1121 AS Decimal(18, 0)), NULL, NULL, NULL, 1, 1, NULL, N'string', 1, N'string', CAST(N'2023-07-08T15:18:44.5056500' AS DateTime2), N'string', CAST(N'2023-07-08T15:18:44.5051269' AS DateTime2))
INSERT [dbo].[Comprobantes] ([Id], [Consecutivo], [Descripcion], [Valor], [TerceroId], [CategoriaComprobanteId], [DocumentoId], [TipoConfiguracionDocumentoId], [EmpresaId], [FormaPagoId], [ReferenciaPago], [Estado], [CreadoPor], [FechaCreacion], [ModificadoPor], [FechaModificacion]) VALUES (6, 1, N'string', CAST(1121 AS Decimal(18, 0)), NULL, NULL, NULL, 1, 1, NULL, N'string', 1, N'string', CAST(N'2023-07-08T15:25:08.4035901' AS DateTime2), N'string', CAST(N'2023-07-08T15:25:08.4033372' AS DateTime2))
INSERT [dbo].[Comprobantes] ([Id], [Consecutivo], [Descripcion], [Valor], [TerceroId], [CategoriaComprobanteId], [DocumentoId], [TipoConfiguracionDocumentoId], [EmpresaId], [FormaPagoId], [ReferenciaPago], [Estado], [CreadoPor], [FechaCreacion], [ModificadoPor], [FechaModificacion]) VALUES (7, 2, N'string actualizadop', CAST(100 AS Decimal(18, 0)), NULL, NULL, NULL, 1, 1, NULL, N'', 0, N'string', CAST(N'2023-07-08T15:29:07.9266315' AS DateTime2), N'modif', CAST(N'2023-07-08T15:29:41.6761165' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Comprobantes] OFF
GO
INSERT [dbo].[ConfiguracionDocumentos] ([Id], [EmpresaId], [NombreDocumento], [Codigo], [Prefijo], [Sufijo], [AfectaInventario], [ConsecutivoInicial], [ConsecutivoActual], [ConsecutivoFinal], [Mensaje], [Mensaje2]) VALUES (1, 1, N'Comprobante de Egreso', N'CE', N'', N'', 0, 1, 0, 1000000, NULL, NULL)
GO
INSERT [dbo].[Departamentos] ([Id], [Descripcion]) VALUES (1, N'Córdoba')
GO
SET IDENTITY_INSERT [dbo].[Empresas] ON 

INSERT [dbo].[Empresas] ([Id], [Nombre], [Nit], [Direccion], [Telefonos]) VALUES (1, N'Osaka Comercial', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Empresas] OFF
GO
SET IDENTITY_INSERT [dbo].[FormasPago] ON 

INSERT [dbo].[FormasPago] ([Id], [Descripcion]) VALUES (1, N'Efectivo')
INSERT [dbo].[FormasPago] ([Id], [Descripcion]) VALUES (2, N'Tarjeta Debito')
INSERT [dbo].[FormasPago] ([Id], [Descripcion]) VALUES (3, N'Tarjeta Credito')
INSERT [dbo].[FormasPago] ([Id], [Descripcion]) VALUES (4, N'Nequi')
INSERT [dbo].[FormasPago] ([Id], [Descripcion]) VALUES (5, N'Daviplata')
INSERT [dbo].[FormasPago] ([Id], [Descripcion]) VALUES (6, N'Ahorro a la mano')
SET IDENTITY_INSERT [dbo].[FormasPago] OFF
GO
INSERT [dbo].[Municipios] ([Id], [Descripcion], [DepartamentoId]) VALUES (1, N'Montería', 1)
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([Id], [Codigo], [CodigoBarras], [Nombre], [UnidadMedidaId], [CategoriaId], [CostoPonderado], [PrecioVenta], [StockMinimo], [StockActual], [StockMaximo], [Ubicacion], [EmpresaId], [Estado], [CreadoPor], [FechaCreacion], [ModificadoPor], [FechaModificacion]) VALUES (4, N'10100', N'12300', N'PonyMalta', 2, 1, CAST(100 AS Decimal(18, 0)), CAST(2300 AS Decimal(18, 0)), 1, 300, 530, N'Almacen', 1, 0, N'DELAOSSA', CAST(N'2023-06-16T17:44:18.8259570' AS DateTime2), N'Katius', CAST(N'2023-06-17T12:02:17.5749103' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Terceros] ON 

INSERT [dbo].[Terceros] ([Id], [EmpresaId], [TipoIdentificacionId], [Numero], [Tipo], [Nombre], [Direccion], [Celular], [Telefono], [Email], [DepartamentoId], [MunicipioId], [Calificacion], [Observaciones], [Estado], [CreadoPor], [FechaCreacion], [ModificadoPor], [FechaModificacion]) VALUES (1, 1, 1, N'1067872687', 2, N'OSCAR JOSE SANCHEZ CALLE', N'Mz 6 Lt 11', N'3008491755', N'', N'oscar.jsc@outlook.com', 1, 1, 0, N'Actualizado', 0, N'SANCHEZO', CAST(N'2023-06-10T12:43:04.7889954' AS DateTime2), N'SANCHEZO', CAST(N'2023-06-10T12:59:13.0948242' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Terceros] OFF
GO
SET IDENTITY_INSERT [dbo].[TiposIdentificacion] ON 

INSERT [dbo].[TiposIdentificacion] ([Id], [Descripcion]) VALUES (1, N'Cédula de Ciudadania')
INSERT [dbo].[TiposIdentificacion] ([Id], [Descripcion]) VALUES (2, N'NIT')
INSERT [dbo].[TiposIdentificacion] ([Id], [Descripcion]) VALUES (3, N'Cédula Extranjería')
INSERT [dbo].[TiposIdentificacion] ([Id], [Descripcion]) VALUES (4, N'Pasaporte')
SET IDENTITY_INSERT [dbo].[TiposIdentificacion] OFF
GO
SET IDENTITY_INSERT [dbo].[UnidadesMedida] ON 

INSERT [dbo].[UnidadesMedida] ([Id], [Simbolo], [Nombre]) VALUES (1, N'u', N'Unidad')
INSERT [dbo].[UnidadesMedida] ([Id], [Simbolo], [Nombre]) VALUES (2, N'm', N'Metro')
INSERT [dbo].[UnidadesMedida] ([Id], [Simbolo], [Nombre]) VALUES (3, N'cm', N'Centrimetro')
INSERT [dbo].[UnidadesMedida] ([Id], [Simbolo], [Nombre]) VALUES (4, NULL, N'')
SET IDENTITY_INSERT [dbo].[UnidadesMedida] OFF
GO
ALTER TABLE [dbo].[Comprobantes]  WITH CHECK ADD  CONSTRAINT [FK_Comprobantes_CategoriasComprobantes] FOREIGN KEY([CategoriaComprobanteId])
REFERENCES [dbo].[CategoriasComprobantes] ([Id])
GO
ALTER TABLE [dbo].[Comprobantes] CHECK CONSTRAINT [FK_Comprobantes_CategoriasComprobantes]
GO
ALTER TABLE [dbo].[Comprobantes]  WITH CHECK ADD  CONSTRAINT [FK_Comprobantes_FormasPago] FOREIGN KEY([FormaPagoId])
REFERENCES [dbo].[FormasPago] ([Id])
GO
ALTER TABLE [dbo].[Comprobantes] CHECK CONSTRAINT [FK_Comprobantes_FormasPago]
GO
ALTER TABLE [dbo].[Documentos]  WITH CHECK ADD  CONSTRAINT [FK_Documentos_FormasPago] FOREIGN KEY([FormaPagoId])
REFERENCES [dbo].[FormasPago] ([Id])
GO
ALTER TABLE [dbo].[Documentos] CHECK CONSTRAINT [FK_Documentos_FormasPago]
GO
ALTER TABLE [dbo].[DocumentosImpuestosTotales]  WITH CHECK ADD  CONSTRAINT [FK_DocumentosImpuestosTotales_Documentos] FOREIGN KEY([DocumentoId])
REFERENCES [dbo].[Documentos] ([Id])
GO
ALTER TABLE [dbo].[DocumentosImpuestosTotales] CHECK CONSTRAINT [FK_DocumentosImpuestosTotales_Documentos]
GO
ALTER TABLE [dbo].[DocumentosProductos]  WITH CHECK ADD  CONSTRAINT [FK_DocumentosProductos_Documentos] FOREIGN KEY([DocumentoId])
REFERENCES [dbo].[Documentos] ([Id])
GO
ALTER TABLE [dbo].[DocumentosProductos] CHECK CONSTRAINT [FK_DocumentosProductos_Documentos]
GO
ALTER TABLE [dbo].[DocumentosProductosImpuestos]  WITH CHECK ADD  CONSTRAINT [FK_DocumentosProductosImpuestos_DocumentosProductos] FOREIGN KEY([DocumentoProductoId])
REFERENCES [dbo].[DocumentosProductos] ([Id])
GO
ALTER TABLE [dbo].[DocumentosProductosImpuestos] CHECK CONSTRAINT [FK_DocumentosProductosImpuestos_DocumentosProductos]
GO
ALTER TABLE [dbo].[Exenciones]  WITH CHECK ADD  CONSTRAINT [FK_Exenciones_Impuestos] FOREIGN KEY([ImpuestoId])
REFERENCES [dbo].[Impuestos] ([Id])
GO
ALTER TABLE [dbo].[Exenciones] CHECK CONSTRAINT [FK_Exenciones_Impuestos]
GO
ALTER TABLE [dbo].[Exenciones]  WITH CHECK ADD  CONSTRAINT [FK_Exenciones_Productos] FOREIGN KEY([ProductoId])
REFERENCES [dbo].[Productos] ([Id])
GO
ALTER TABLE [dbo].[Exenciones] CHECK CONSTRAINT [FK_Exenciones_Productos]
GO
ALTER TABLE [dbo].[Exenciones]  WITH CHECK ADD  CONSTRAINT [FK_Exenciones_Terceros] FOREIGN KEY([TerceroId])
REFERENCES [dbo].[Terceros] ([Id])
GO
ALTER TABLE [dbo].[Exenciones] CHECK CONSTRAINT [FK_Exenciones_Terceros]
GO
ALTER TABLE [dbo].[Municipios]  WITH CHECK ADD  CONSTRAINT [FK_Municipios_Departamentos] FOREIGN KEY([DepartamentoId])
REFERENCES [dbo].[Departamentos] ([Id])
GO
ALTER TABLE [dbo].[Municipios] CHECK CONSTRAINT [FK_Municipios_Departamentos]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Categorias] FOREIGN KEY([CategoriaId])
REFERENCES [dbo].[Categorias] ([Id])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Categorias]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_UnidadesMedida] FOREIGN KEY([UnidadMedidaId])
REFERENCES [dbo].[UnidadesMedida] ([Id])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_UnidadesMedida]
GO
ALTER TABLE [dbo].[Terceros]  WITH CHECK ADD  CONSTRAINT [FK_Terceros_Municipios] FOREIGN KEY([MunicipioId])
REFERENCES [dbo].[Municipios] ([Id])
GO
ALTER TABLE [dbo].[Terceros] CHECK CONSTRAINT [FK_Terceros_Municipios]
GO
ALTER TABLE [dbo].[Terceros]  WITH CHECK ADD  CONSTRAINT [FK_Terceros_TiposIdentificacion] FOREIGN KEY([TipoIdentificacionId])
REFERENCES [dbo].[TiposIdentificacion] ([Id])
GO
ALTER TABLE [dbo].[Terceros] CHECK CONSTRAINT [FK_Terceros_TiposIdentificacion]
GO
ALTER DATABASE [fedra-dev] SET  READ_WRITE 
GO
