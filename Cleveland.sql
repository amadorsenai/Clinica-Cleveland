create database Cleveland;

use Cleveland;

create table Medicos (
IdMedico   int primary key identity 
,nome     varchar (200) not null 
,nascimento    date not null
,crm      int  not null unique 
)

insert into Medicos (nome,nascimento, crm) VALUES ('Roberto', '31/05/1978','012345678');
insert into Medicos (nome,nascimento, crm) VALUES ('Carla', '28/08/1975','147258369');
insert into Medicos (nome,nascimento, crm) VALUES ('Eduardo', '11/06/1980','159263487');
insert into Medicos (nome,nascimento, crm) VALUES ('Maria', '15/04/1973','326159487');

select * from Medicos