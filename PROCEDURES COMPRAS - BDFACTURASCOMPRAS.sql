--
--Usar base de datos Empresa
use BDFACTURASCOMPRAS
go
--
------------------------------------------CREACION DE PROCEDURES-----------------------------------------------
------------------------------------------PARA COMPRA-----------------------------------------------
--
-----INTERFACE REGISTRAR COMPRA
--
--Procedure Registrar Compra
create or alter procedure regitrar_Compra
@fecha_Compra date,
@Serie varchar(4),
@Comprobante varchar(10),
@RUC varchar(11),
@Sub_Total decimal(5,2),
@Estado varchar(2)
as
insert into Tabla_Compra(fecha_Compra,Serie,Comprobante,RUC,Sub_Total,Estado)
values (@fecha_Compra, @Serie, @Comprobante,@RUC,@Sub_Total,@Estado)
go
--
exec regitrar_Compra '2022-10-05','F002','9876543210', '20503840121',10.68,'No'
go
--
select * from Tabla_Compra
go
--
--
-----INTERFACE MANTENIMIENTO COMPRA
--
--Procedure buscar Compra
create or alter procedure Mostrar_Detalle_Compra
@codigo int
as
select C.Codigo,C.fecha_Compra, C.Serie, C.Comprobante, C.RUC, R.razonSocial, C.Sub_Total, C.Total, C.Estado
from Tabla_Compra C, Tabla_Ruc R
where Codigo=@codigo and C.RUC=R.ruc
go
--
--execute Mostrar_Detalle_Compra 6
--go
--
select * from Tabla_Compra
go
--
--SELECT * FROM Tabla_Compra where Codigo=3
--GO
--
--Procedure Actualizar Compra
--
create or alter procedure actualizar_Compra
@codigo int,
@fecha_Compra date,
@Serie varchar(4),
@Comprobante varchar(10),
@RUC varchar(11),
@Sub_Total decimal(5,2),
@Estado varchar(2)
as
update Tabla_Compra 
set 
fecha_Compra=@fecha_Compra,
Serie=@Serie,
Comprobante=@Comprobante,
RUC=@RUC,
Sub_Total=@Sub_Total,
Estado=@Estado 
where Codigo=@codigo;
go
--
--exec actualizar_Compra 1,'2022-10-06','F001','1234567890','20513567139',225.42,'No'
--go
--
select * from Tabla_Compra
go
--
--
--Procedimiento Eliminar Compra
--
create or alter procedure Eliminar_Productos
@codigo int
as
delete from Tabla_Compra where Codigo=@codigo;
go
--
--exec Eliminar_Productos 3
--go
--
select * from Tabla_Compra
go
--
-----INTERFACE MODIFICAR ESTADO DE COMPRA
--
--Procedure modificar el estado de compra como ya exportado
--
create or alter procedure Modificar_EstadoCompra
@codigo int,
@Estado varchar(2)
as
update Tabla_Compra 
set 
Estado=@Estado
where Codigo<=@codigo;
go
--
--exec Modificar_EstadoCompra 6,'No'
--go
--
select * from Tabla_Compra
go
--
--
-----INTERFACE GENERAR REPORTE
--
--Procedure buscar Compra
create or alter procedure Mostrar_Para_exportar
@estado varchar(2)
as
select C.Codigo,C.fecha_Compra, C.Serie, C.Comprobante, C.RUC, R.razonSocial, C.Sub_Total, C.Total, C.Estado
from Tabla_Compra C, Tabla_Ruc R
where Estado=@estado and C.RUC=R.ruc
go
--
--execute Mostrar_Para_exportar 'No'
--go
--
select * from Tabla_Compra
go
--
--
-----INTERFACE VERIFICACION DE COMPRA
--
create or alter procedure Verificacion_compra
@fecha date
as
select C.Codigo,C.fecha_Compra, C.Serie, C.Comprobante, C.RUC, R.razonSocial, C.Sub_Total, C.Total, C.Estado
from Tabla_Compra C, Tabla_Ruc R
where fecha_Compra=@fecha and C.RUC=R.ruc
go
--
--execute Verificacion_compra '2022-10-08'
--go
--
select * from Tabla_Compra
go




