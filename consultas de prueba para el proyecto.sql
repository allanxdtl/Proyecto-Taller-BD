create function defNombreCompletoAgentes(@Patente as int) returns varchar(153) as
begin
	declare @FullName as varchar(153)
	select @FullName=isnull(Nombre, '')+' '+isnull(ApellidoPaterno, '')+' '+isnull(ApellidoMaterno, '')
	from AgentesAduanales 
	where patente=@patente

	return @FullName
end

SELECT Articulos.Nombre as Producto, Cantidad, Cantidad*Articulos.Precio as Total
from PedimentosDetail inner join Articulos on PedimentosDetail.IDArticulo=Articulos.IDArticulo 
where IDPedimento=1

select sum(cantidad*Articulos.Precio*1.21) as total
from PedimentosDetail inner join Articulos on PedimentosDetail.IDArticulo=Articulos.IDArticulo 
group by Cantidad

select Patente, dbo.defNombreCompletoAgentes(Patente) as 'Nombre Completo' from AgentesAduanales order by 'Nombre Completo' asc