create procedure Sp_RegistrarNuevoPedimentoHeader 
@IDPedimento varchar(20),
@Agente int,
@Importador varchar(13),
@Total decimal(5,0),
@Aduana int,
@fecha datetime
as
insert into PedimentosHeader values (@IDPedimento, @agente, @importador, @total, @aduana, @fecha)

create procedure Sp_RegistrarNuevoPedimentoDetail
@IdPedimento varchar(20),
@Articulo varchar(20),
@Cantidad int
as
insert into PedimentosDetail values (@IdPedimento, @Articulo, @cantidad)

alter procedure SP_getPedimento
@IDPedimento varchar(20)
as
begin
	select PH.IDPedimento, 
	dbo.defNombreCompletoAgentes(AA.Patente) as 'Nombre del Agente', 
	I.Nombre , A.Ciudad, concat(day(fecha),'-', month(fecha), '-', year(fecha)) as 'Fecha',
	PH.Total
	from PedimentosHeader PH 
	inner join AgentesAduanales AA on AA.Patente=PH.Agente
	inner join Importadores I on PH.Importador=I.IDImportador
	inner join Aduanas A on PH.Aduana=A.ID
	where IDPedimento=@IDPedimento
	
	select A.Nombre, A.Precio, PD.Cantidad, A.Precio*PD.Cantidad as SUBTOTAL
	from PedimentosDetail PD inner join Articulos A on PD.IDArticulo=A.IDArticulo 
	where IDPedimento=@IDPedimento
end


create procedure sp_BuscarPorFecha
@Dia int,
@Mes int,
@Anio int
as
begin
	select IDPedimento, dbo.defNombreCompletoAgentes(AA.Patente) as 'Nombre del Agente', Fecha
	from PedimentosHeader PH inner join AgentesAduanales AA on AA.Patente=PH.Agente
	where day(fecha)=@dia and month(fecha)=@mes and year(fecha)=@anio
end

exec Sp_BuscarPorFecha 6,12,2023

select IDPedimento
from PedimentosDetail PD inner join Articulos A on PD.IDArticulo=A.IDArticulo 
where A.IDArticulo=321

select idPedimento, cast(day(fecha) as varchar) + '/'+ cast(MONTH(fecha) as varchar)+'/'+ cast(year(fecha) as varchar) as 'Fecha de Expedicion' from PedimentosHeader PH inner join Aduanas A on A.ID=PH.Aduana where A.ID=50

select IDPedimento, cast(day(fecha) as varchar) + '/'+ cast(MONTH(fecha) as varchar)+'/'+ cast(year(fecha) as varchar) as 'Fecha de Expedicion' 
from PedimentosHeader PH inner join Importadores I on PH.Importador=I.IDImportador
where I.Nombre like '%master%'

select Agente from PedimentosHeader where IDPedimento='19 50 9999 3318257'