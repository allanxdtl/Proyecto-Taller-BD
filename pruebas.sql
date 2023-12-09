select patente, Ciudad as 'Ciudad Donde Trabaja', isnull(Nombre, '')+' '+isnull(apellidoPaterno, '')+' '+isnull(apellidoMaterno, '') as 'Nombre Completo', RFC
from AgentesAduanales inner join Aduanas on AgentesAduanales.AgenciaAduanal=Aduanas.ID
where Ciudad like'%Nogales%'

use aduana
select * from Importadores