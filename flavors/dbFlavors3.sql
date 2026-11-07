CREATE DATABASE dbFlavors
USE [dbFlavors]
GO
/****** Object:  Table [dbo].[tbClientes]    Script Date: 18/11/2023 18:40:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbClientes](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[id_estado_cliente] [int] NULL,
	[nombre_cliente] [varchar](80) NULL,
	[correo] [varchar](50) NULL,
	[direccion] [varchar](200) NULL,
	[telefono] [varchar](9) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbDetallePedidos]    Script Date: 18/11/2023 18:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbDetallePedidos](
	[id_detalle_pedido] [int] IDENTITY(1,1) NOT NULL,
	[id_pedido] [int] NULL,
	[id_producto] [int] NULL,
	[cantidad] [int] NULL,
	[subtotal] [decimal](4, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_detalle_pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbEmpleados]    Script Date: 18/11/2023 18:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbEmpleados](
	[id_empleado] [int] IDENTITY(1,1) NOT NULL,
	[id_estado_empleado] [int] NULL,
	[nombre_empleado] [varchar](80) NULL,
	[fecha_nacimiento] [date] NULL,
	[dui] [varchar](10) NULL,
	[telefono] [varchar](9) NULL,
	[direccion] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbEstadoClientes]    Script Date: 18/11/2023 18:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbEstadoClientes](
	[id_estado_cliente] [int] IDENTITY(1,1) NOT NULL,
	[estado_cliente] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_estado_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbEstadoEmpleados]    Script Date: 18/11/2023 18:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbEstadoEmpleados](
	[id_estado_empleado] [int] IDENTITY(1,1) NOT NULL,
	[estado_empleado] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_estado_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbEstadoUsuarios]    Script Date: 18/11/2023 18:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbEstadoUsuarios](
	[id_estado_usuario] [int] IDENTITY(1,1) NOT NULL,
	[estado_usuario] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_estado_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbMesas]    Script Date: 18/11/2023 18:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbMesas](
	[id_mesa] [int] IDENTITY(1,1) NOT NULL,
	[mesa] [varchar](5) NULL,
	[capacidad] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_mesa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbPedidos]    Script Date: 18/11/2023 18:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPedidos](
	[id_pedido] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo_pedido] [int] NULL,
	[id_usuario] [int] NULL,
	[id_cliente] [int] NULL,
	[id_mesa] [int] NULL,
	[fechahora] [datetime] NULL,
	[total] [decimal](5, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbProductos]    Script Date: 18/11/2023 18:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbProductos](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo_producto] [int] NULL,
	[nombre_producto] [varchar](50) NULL,
	[precio_producto] [decimal](5, 2) NULL,
	[descripcion_producto] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbTipoPedidos]    Script Date: 18/11/2023 18:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbTipoPedidos](
	[id_tipo_pedido] [int] IDENTITY(1,1) NOT NULL,
	[tipo_pedido] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo_pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbTipoProductos]    Script Date: 18/11/2023 18:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbTipoProductos](
	[id_tipo_producto] [int] IDENTITY(1,1) NOT NULL,
	[tipo_producto] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbTipoUsuarios]    Script Date: 18/11/2023 18:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbTipoUsuarios](
	[id_tipo_usuario] [int] IDENTITY(1,1) NOT NULL,
	[tipo_usuario] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbUsuarios]    Script Date: 18/11/2023 18:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbUsuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo_usuario] [int] NULL,
	[id_estado_usuario] [int] NULL,
	[id_empleado] [int] NULL,
	[usuario] [varchar](20) NULL,
	[contrasenia] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbClientes]  WITH CHECK ADD  CONSTRAINT [fk_estado_cliente] FOREIGN KEY([id_estado_cliente])
REFERENCES [dbo].[tbEstadoClientes] ([id_estado_cliente])
GO
ALTER TABLE [dbo].[tbClientes] CHECK CONSTRAINT [fk_estado_cliente]
GO
ALTER TABLE [dbo].[tbDetallePedidos]  WITH CHECK ADD  CONSTRAINT [fk_pedido] FOREIGN KEY([id_pedido])
REFERENCES [dbo].[tbPedidos] ([id_pedido])
GO
ALTER TABLE [dbo].[tbDetallePedidos] CHECK CONSTRAINT [fk_pedido]
GO
ALTER TABLE [dbo].[tbDetallePedidos]  WITH CHECK ADD  CONSTRAINT [fk_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[tbProductos] ([id_producto])
GO
ALTER TABLE [dbo].[tbDetallePedidos] CHECK CONSTRAINT [fk_producto]
GO
ALTER TABLE [dbo].[tbEmpleados]  WITH CHECK ADD  CONSTRAINT [fk_estado_usuario] FOREIGN KEY([id_estado_empleado])
REFERENCES [dbo].[tbEstadoEmpleados] ([id_estado_empleado])
GO
ALTER TABLE [dbo].[tbEmpleados] CHECK CONSTRAINT [fk_estado_usuario]
GO
ALTER TABLE [dbo].[tbPedidos]  WITH CHECK ADD  CONSTRAINT [fk_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[tbClientes] ([id_cliente])
GO
ALTER TABLE [dbo].[tbPedidos] CHECK CONSTRAINT [fk_cliente]
GO
ALTER TABLE [dbo].[tbPedidos]  WITH CHECK ADD  CONSTRAINT [fk_mesa] FOREIGN KEY([id_mesa])
REFERENCES [dbo].[tbMesas] ([id_mesa])
GO
ALTER TABLE [dbo].[tbPedidos] CHECK CONSTRAINT [fk_mesa]
GO
ALTER TABLE [dbo].[tbPedidos]  WITH CHECK ADD  CONSTRAINT [fk_tipo_pedido] FOREIGN KEY([id_tipo_pedido])
REFERENCES [dbo].[tbTipoPedidos] ([id_tipo_pedido])
GO
ALTER TABLE [dbo].[tbPedidos] CHECK CONSTRAINT [fk_tipo_pedido]
GO
ALTER TABLE [dbo].[tbPedidos]  WITH CHECK ADD  CONSTRAINT [fk_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[tbUsuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[tbPedidos] CHECK CONSTRAINT [fk_usuario]
GO
ALTER TABLE [dbo].[tbProductos]  WITH CHECK ADD  CONSTRAINT [fk_tipo_producto] FOREIGN KEY([id_tipo_producto])
REFERENCES [dbo].[tbTipoProductos] ([id_tipo_producto])
GO
ALTER TABLE [dbo].[tbProductos] CHECK CONSTRAINT [fk_tipo_producto]
GO
ALTER TABLE [dbo].[tbUsuarios]  WITH CHECK ADD  CONSTRAINT [fk_empleado] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[tbEmpleados] ([id_empleado])
GO
ALTER TABLE [dbo].[tbUsuarios] CHECK CONSTRAINT [fk_empleado]
GO
ALTER TABLE [dbo].[tbUsuarios]  WITH CHECK ADD  CONSTRAINT [fk_estado_usuarioo] FOREIGN KEY([id_estado_usuario])
REFERENCES [dbo].[tbEstadoUsuarios] ([id_estado_usuario])
GO
ALTER TABLE [dbo].[tbUsuarios] CHECK CONSTRAINT [fk_estado_usuarioo]
GO
ALTER TABLE [dbo].[tbUsuarios]  WITH CHECK ADD  CONSTRAINT [fk_tipo_usuario] FOREIGN KEY([id_tipo_usuario])
REFERENCES [dbo].[tbTipoUsuarios] ([id_tipo_usuario])
GO
ALTER TABLE [dbo].[tbUsuarios] CHECK CONSTRAINT [fk_tipo_usuario]
GO
