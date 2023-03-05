--creacion de la base de datos
create database BDFACTURASCOMPRAS
go
--
use BDFACTURASCOMPRAS
go
--

------------------------------------------CREACION DE TABLAS-----------------------------------------------
--
--TABLA RUC
create table Tabla_Ruc
(
ruc varchar(11) not null primary key,
razonSocial varchar(30) not null
)
go
--insert into Tabla_Ruc values ('20513567139','ALTA VIDDA GAS SAC')
--go
select * from Tabla_Ruc
go
--
--TABLA COMPRA
create table Tabla_Compra
(
Codigo int identity(1,1) not null primary key,
fecha_Compra date not null,
Serie varchar(4) not null,
Comprobante varchar(10) not null,
RUC varchar(11) not null,
Sub_Total decimal(5,2) not null,
--
Total as (Sub_Total + (Sub_Total * 0.18)),
Estado varchar(2),
--estableciendo llaves foraneas
constraint FK_Tabla_Compra_ruc foreign key (RUC) references Tabla_Ruc(RUC)
)
go
--insert into Tabla_Compra values ('2022-10-06','F001','1234567890','20513567139',225.42,'No')
--go
select * from Tabla_Compra
go
--
--Creacion de la tabla Login
--
create table Acceso
(
Usuario varchar(5) not null,
Clave varchar(5) not null
)
insert into Acceso values ('user','2004C')
go
select * from Acceso
go














