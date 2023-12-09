alter table pedimentosHeader 
add constraint fk_Agente foreign key (Agente) references AgentesAduanales(Patente)

alter table pedimentosHeader
add constraint fk_Aduana foreign key (Aduana) references Aduanas(ID)

alter table pedimentosDetail 
add constraint fk_IdArticulo foreign key (IDArticulo) references Articulos(IDArticulo)

alter table pedimentosDetail 
add constraint fk_IDPedimento foreign key (IDPedimento) references pedimentosHeader(IDPedimento)

