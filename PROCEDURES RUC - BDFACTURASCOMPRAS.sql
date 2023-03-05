--
--Usar base de datos Empresa
use BDFACTURASCOMPRAS
go
--
------------------------------------------CREACION DE PROCEDURES-----------------------------------------------
------------------------------------------PARA RUC-----------------------------------------------
--
-----INTERFACE REGISTRAR RUC
--
--procedimiento para registrar ruc
--
create or alter procedure regitrar_Ruc
@ruc varchar(11),
@razonSocial varchar(30)
as
insert into Tabla_Ruc(ruc,razonSocial)
values (@ruc, @razonSocial)
go
--
exec regitrar_Ruc '20503840121','REPSOL'
go
--
select * from Tabla_Ruc
go
--
-----INTERFACE MANTENIMIENTO RUC
--
--procedimiento para buscar ruc
create or alter procedure buscar_ruc
@ruc varchar(11)
as
select ruc,razonSocial
from Tabla_Ruc
where ruc=@ruc
go
--
--execute buscar_ruc '20503840121'
--go
--
select * from Tabla_Ruc
go
--
--procedimiento para actualizar ruc
--
create or alter procedure actualizar_ruc
@rucAct varchar(11),
@rucNue varchar(11),
@razonSocial varchar(30)
as
update Tabla_Ruc 
set
ruc=@rucNue,
razonSocial=@razonSocial
where ruc=@rucAct;
go
--
--exec actualizar_ruc '20503840121','20503840120','REPSOL1'
--go
--
select * from Tabla_Ruc
go
--
--procedimiento para aliminar ruc
--
create or alter procedure Eliminar_ruc
@ruc varchar(11)
as
delete from Tabla_Ruc where ruc=@ruc;
go
--
--exec Eliminar_ruc '20503840120'
--go
--
select * from Tabla_Ruc
go
















