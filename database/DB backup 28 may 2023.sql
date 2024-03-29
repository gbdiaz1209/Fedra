/****** Object:  Table [dbo].[Categorias]    Script Date: 5/28/2023 4:16:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[Id] [bigint] NOT NULL,
	[Descripcion] [varchar](250) NULL,
	[EmpresaId] [bigint] NULL,
	[Estado] [int] NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CondicionesPago]    Script Date: 5/28/2023 4:16:26 PM ******/
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
/****** Object:  Table [dbo].[ConfiguracionDocumentos]    Script Date: 5/28/2023 4:16:26 PM ******/
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
/****** Object:  Table [dbo].[Departamentos]    Script Date: 5/28/2023 4:16:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamentos](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](250) NULL,
 CONSTRAINT [PK_Departamentos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Documentos]    Script Date: 5/28/2023 4:16:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Documentos](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[TipoDocumentoId] [bigint] NULL,
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
	[FechaModificacion] [datetime2](7) NOT NULL,
	[CreadoPor] [varchar](50) NOT NULL,
	[FechaCreacion] [datetime2](7) NOT NULL,
	[ModificadoPor] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Documentos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocumentosImpuestosTotales]    Script Date: 5/28/2023 4:16:26 PM ******/
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
/****** Object:  Table [dbo].[DocumentosProductos]    Script Date: 5/28/2023 4:16:26 PM ******/
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
/****** Object:  Table [dbo].[DocumentosProductosImpuestos]    Script Date: 5/28/2023 4:16:26 PM ******/
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
/****** Object:  Table [dbo].[Empresas]    Script Date: 5/28/2023 4:16:26 PM ******/
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
/****** Object:  Table [dbo].[Exenciones]    Script Date: 5/28/2023 4:16:26 PM ******/
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
/****** Object:  Table [dbo].[FormasPago]    Script Date: 5/28/2023 4:16:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormasPago](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](255) NULL,
 CONSTRAINT [PK_FormasPago] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Impuestos]    Script Date: 5/28/2023 4:16:26 PM ******/
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
/****** Object:  Table [dbo].[Municipios]    Script Date: 5/28/2023 4:16:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Municipios](
	[Id] [bigint] NOT NULL,
	[Descripcion] [varchar](250) NULL,
	[DepartamentoId] [bigint] NULL,
 CONSTRAINT [PK_Municipios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 5/28/2023 4:16:26 PM ******/
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
	[Ubicabion] [varchar](500) NULL,
	[EmpresaId] [bigint] NOT NULL,
	[Estado] [int] NULL,
	[CreadoPor] [varchar](50) NOT NULL,
	[FechaCreacion] [datetime2](7) NOT NULL,
	[ModificadoPor] [varchar](50) NOT NULL,
	[FechaModificacion] [datetime2](7) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Terceros]    Script Date: 5/28/2023 4:16:26 PM ******/
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
/****** Object:  Table [dbo].[TiposIdentificacion]    Script Date: 5/28/2023 4:16:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposIdentificacion](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_TiposIdentificacion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnidadesMedida]    Script Date: 5/28/2023 4:16:26 PM ******/
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
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Exenciones] FOREIGN KEY([Id])
REFERENCES [dbo].[Exenciones] ([Id])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Exenciones]
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
