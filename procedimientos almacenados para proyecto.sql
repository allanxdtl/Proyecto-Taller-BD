alter procedure spLogin
@user varchar(50),
@pass varchar(50)
as
begin
	select username, password, tipo_User from Usuarios where username=@user and password=@pass
end


select A.Nombre as 'Nombre del Articulo', sum(PD.Cantidad) as 'Total exportados/importados'
from Articulos A inner join PedimentosDetail PD 
on A.IDArticulo=PD.IDArticulo
group by A.Nombre
order by 'Total exportados/importados' desc


