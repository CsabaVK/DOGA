create database nagyker;
use nagyker

create table boltok(
id int primary key identity(1, 1),
nev varchar (30),
cim varchar (30));

create table rendelesek(
id int primary key identity(1, 1),
bolt int foreign key references boltok(id),
termek varchar(50),
mennyiseg int);

insert into boltok (nev, cim) values
('Marinéni vegyesboltja', 'BP13, Végh Béla u. 13/b'),
('1edi ajándékbolt', 'BP20, Vörös Marty utca 69.'),
('Tolyásbolt Pontoslyével', 'BP13, Lakatos Nintendó út 10'),
('Mellékes Kellékek', 'BP12, Sakko Zoltán krt. 33b');

insert into rendelesek(bolt, termek, mennyiseg) values
(1, 'tej', 5),
(4, 'olyan izé, ami szokott lenni, de most nem látok', 1),
(1, 'kenyér', 5),
(2, 'fluxuskondenzátor', 3),
(1, 'tojás M', 60),
(2, 'konyharuha szett, kockás', 10),
(4, 'ami a Barátokköztben volt az aszalon a Maricinál', 1),
(3, 'tojás XL', 60),
(1, 'fagyöngy ízű szalámi', 20),
(1, 'tojás M', 20),
(3, 'tojás XL', 60),
(4, 'az a cucc, amit az ablakra kell tenni', 1),
(3, 'tojás M', 40),
(2, 'szalámi ízű fagyöngy', 12),
(4, 'váratlan árucikk a csomagolóterületről', 99);


Data Source=(localdb)\MSSQLLocalDB;
Initial Catalog=nagyker;
Integrated Security=True;
Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False