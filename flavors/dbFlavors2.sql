create database dbFlavors
use dbFlavors

create table tbEstadoUsuarios (
id_estado_usuario int primary key identity (1,1),
estado_usuario varchar(20)
);

create table tbTipoUsuarios (
id_tipo_usuario int primary key identity (1,1),
tipo_usuario varchar(20),
);

create table tbEstadoEmpleados(
id_estado_empleado int primary key identity(1,1),
estado_empleado varchar(20)
);

create table tbEmpleados(
id_empleado int primary key identity(1,1),
id_estado_empleado int,
nombre_empleado varchar(80),
fecha_nacimiento date,
dui varchar(10),
telefono varchar(9),
direccion varchar(200),

CONSTRAINT fk_estado_usuario FOREIGN KEY (id_estado_empleado) REFERENCES tbEstadoEmpleados(id_estado_empleado)
);

create table tbUsuarios(
id_usuario int primary key identity (1,1),
id_tipo_usuario int,
id_estado_usuario int,
id_empleado int,
usuario varchar(20),
contrasenia varchar(20),

CONSTRAINT fk_tipo_usuario FOREIGN KEY (id_tipo_usuario) REFERENCES tbTipoUsuarios(id_tipo_usuario),
CONSTRAINT fk_estado_usuarioo FOREIGN KEY (id_estado_usuario) REFERENCES tbEstadoUsuarios(id_estado_usuario),
CONSTRAINT fk_empleado FOREIGN KEY(id_empleado) REFERENCES tbEmpleados(id_empleado)
)

create table tbClientes(
id_cliente int primary key identity(1,1),
nombre_cliente varchar(80),
correo varchar(50),
direccion varchar(200),
telefono varchar(9)
);

create table tbTipoProductos(
id_tipo_producto int primary key identity(1,1),
tipo_producto varchar(15)
);

create table tbProductos(
id_producto int primary key identity(1,1),
id_tipo_producto int,
nombre_producto varchar(50),
precio_producto decimal(5,2),
descripcion_producto varchar(100),

CONSTRAINT fk_tipo_producto FOREIGN KEY(id_tipo_producto) REFERENCES tbTipoProductos(id_tipo_producto),
);

create table tbTipoPedidos(
id_tipo_pedido int primary key identity(1,1),
tipo_pedido varchar(50)
);


create table tbMesas(
id_mesa int primary key identity(1,1),
mesa varchar(5),
capacidad int,

);

create table tbPedidos(
id_pedido int primary key identity(1,1),
id_tipo_pedido int,
id_usuario int,
id_cliente int,
id_mesa int,
fechahora datetime,
total decimal(5,2)

CONSTRAINT fk_tipo_pedido FOREIGN KEY(id_tipo_pedido) REFERENCES tbTipoPedidos(id_tipo_pedido),
CONSTRAINT fk_cliente FOREIGN KEY(id_cliente) REFERENCES tbClientes(id_cliente),
CONSTRAINT fk_usuario FOREIGN KEY(id_usuario) REFERENCES tbUsuarios(id_usuario),
CONSTRAINT fk_mesa FOREIGN KEY(id_mesa) REFERENCES tbMesas(id_mesa)
);

create table tbDetallePedidos(
id_detalle_pedido int primary key identity(1,1),
id_pedido int,
id_producto int,
cantidad int,
subtotal decimal(4,2)

CONSTRAINT fk_pedido FOREIGN KEY(id_pedido) REFERENCES tbPedidos(id_pedido),
CONSTRAINT fk_producto FOREIGN KEY(id_producto) REFERENCES tbProductos(id_producto)
);

/*Inserciones obligatorias*/

INSERT INTO tbEstadoEmpleados (estado_empleado) VALUES ('Activo')
INSERT INTO tbEstadoEmpleados (estado_empleado) VALUES ('Inactivo')

INSERT INTO tbEstadoUsuarios (estado_usuario) VALUES ('Activo')
INSERT INTO tbEstadoUsuarios (estado_usuario) VALUES ('Inactivo')

INSERT INTO tbTipoUsuarios (tipo_usuario) VALUES ('ROOT')
INSERT INTO tbTipoUsuarios (tipo_usuario) VALUES ('Administrador')
INSERT INTO tbTipoUsuarios (tipo_usuario) VALUES ('Cajero')


		