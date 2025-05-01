create database gestion_personne
go

use gestion_personne
go

create table personne
(
	id varchar(50),
	nom varchar(50),
	postnom varchar(50),
	prenom varchar(50),
	sexe varchar(1) default 'M',
	constraint pk_personne primary key(id),
	constraint uk_personne unique(nom,postnom,prenom)
)
go

create table adresse
(
	id varchar(50),
	quartier varchar(50),
	commune varchar(50),
	ville varchar(50),
	pays varchar(50),
	constraint pk_adresse primary key(id)
)
go

create table domicile
(
	id varchar(50),
	id_personne varchar(50),
	id_adresse varchar(50),
	avenue varchar(50),
	numero_avenue int,
	constraint pk_domicile primary key(id),
	constraint fk_personne_domicile foreign key(id_personne)
	references personne(id),
	constraint fk_addresse_domicile foreign key(id_adresse)
	references adresse(id)
)
go

create table telephone 
(
	id varchar(50),
	id_personne varchar(50),
	initial varchar(4),
	numero varchar(9),
	constraint pk_telephone primary key(id),
	constraint fk_personne_telephone 
	foreign key(id_personne) references personne(id)
)
go