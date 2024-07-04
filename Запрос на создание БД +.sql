create database [Typography]
on primary
(name='Typography', filename='C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Typography1.mdf',size=10mb, maxsize=400mb, filegrowth=10%)
log on
(name='Журнал', filename='C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TypographyLog1.ldf',size =1mb, maxsize=100mb, filegrowth=10%);
go
Use [Typography]
go
create table sostoianie_zakaza
(kod_sostoiania_zakaza int identity(1,1) not null,
sostoanie_zakaza varchar(50) not null,
primary key(kod_sostoiania_zakaza)
)
go
create table vid_zakazchika
(kod_vida_zakazchika int identity(1,1) not null,
vid_zakazchika varchar(50) not null,
primary key(kod_vida_zakazchika)
)
go
create table yslygi
(kod_yslygi int identity(1,1) not null,
naimenovanie_yslygi varchar(155) not null,
primary key(kod_yslygi)
)
go
create table naimenovanie_prodykcii
(kod_naimenovania_prodykcii int identity(1,1) not null,
naimenovanie_prodykcii varchar(155) not null,
primary key(kod_naimenovania_prodykcii)
)
go
create table vid_pechati
(kod_vida_pechati int identity(1,1) not null,
vid_pechati varchar(155) not null,
primary key(kod_vida_pechati)
)
go
create table material
(kod_materiala int identity(1,1) not null,
material varchar(155) not null,
primary key(kod_materiala)
)
go
create table vid_oplat
(kod_vida_oplat int identity(1,1) not null,
vid_oplat varchar(155) not null,
primary key(kod_vida_oplat)
)
go
create table maket
(kod_maketa int identity(1,1) not null,
naimenovanie varchar(155) not null,
tip_faila varchar(155) not null,
razmer varchar(50) not null,
razreshenie varchar(50) not null,
glybina_zveta int not null,
data_sozdania date not null,
data_izmenenia date not null,
primary key(kod_maketa)
)
go
create table prodykcia
(kod_prodykcii int identity(1,1) not null,
kod_yslygi int not null,
kod_naimenovania_prodykcii int not null,
shirina real not null,
visota real not null,
kod_vida_pechati int not null,
kod_materiala int not null,
stoimost decimal not null,
primary key(kod_prodykcii),
constraint FK_01 foreign key (kod_yslygi) references yslygi (kod_yslygi),
constraint FK_02 foreign key (kod_naimenovania_prodykcii) references naimenovanie_prodykcii (kod_naimenovania_prodykcii),
constraint FK_03 foreign key (kod_vida_pechati) references vid_pechati (kod_vida_pechati),
constraint FK_04 foreign key (kod_materiala) references material (kod_materiala)
)
go
create table klienti
(kod_klienta int identity(1,1) not null,
fio varchar(255) not null,
adres varchar(255) not null,
tel varchar(50) not null,
email varchar(255) not null,
kod_vida_zakazchika int not null,
naimenovanie_organizacii varchar(255),
iuridicheski_adres varchar(255),
INN_KPP varchar(50) not null,
raschetni_schet int,
nalichie_maketa bit not null,
primary key(kod_klienta),
constraint FK_05 foreign key (kod_vida_zakazchika) references vid_zakazchika (kod_vida_zakazchika)
)
go
create table zakazi
(kod_zakaza int identity(1,1) not null,
kod_prodykcii int not null,
kod_klienta int not null,
data_zakaza date not null,
dizainer bit not null,
kod_vida_oplat int not null,
scidka int not null,
kod_maketa int not null,
kolichestvo int not null,
primary key(kod_zakaza),
constraint FK_06 foreign key (kod_prodykcii) references prodykcia (kod_prodykcii),
constraint FK_07 foreign key (kod_klienta) references klienti (kod_klienta),
constraint FK_08 foreign key (kod_vida_oplat) references vid_oplat (kod_vida_oplat),
constraint FK_09 foreign key (kod_maketa) references maket (kod_maketa)
)
go
create table sostoianie_gotovnosti_zakaza
(kod_zakaza int not null,
kod_klienta int not null,
data_gotovnosti date not null,
kod_sostoiania_zakaza int not null,
constraint FK_10 foreign key (kod_zakaza) references zakazi (kod_zakaza),
constraint FK_11 foreign key (kod_klienta) references klienti (kod_klienta),
constraint FK_12 foreign key (kod_sostoiania_zakaza) references sostoianie_zakaza (kod_sostoiania_zakaza)
)
Use [Typography]
go
insert into [sostoianie_zakaza]
values
('К производству'),
('В производстве'),
('Разработка дизайн-проекта'),
('Расчет'),
('Отменён'),
('Готов к выдаче'),
('Выполнен');
go
insert into [vid_zakazchika]
values
('Юридическое лицо'),
('Физическое лицо');
go
insert into [yslygi]
values
('Широкоформатная печать'),
('Таблички и стенды'),
('Полиграфия');
go
insert into [naimenovanie_prodykcii]
values
('Баннер'),
('Чертёж'),
('Плакат'),
('Фотообои'),
('Афиша'),
('Стенд'),
('Табличка'),
('Режим работы'),
('План эвакуации'),
('Пожарная табличка'),
('Бессмертный полк'),
('Визитка'),
('Листовка'),
('Буклет'),
('Открытка'),
('Приглашение'),
('Наклейка'),
('Меню'),
('Каталог'),
('Конверт'),
('Блокнот'),
('Бланк'),
('Бейдж'),
('Брошюра'),
('Сертификат'),
('Календарь'),
('Дисконт');
go
insert into [vid_pechati]
values
('Высокая печать'),
('Глубокая печать'),
('Плоская печать'),
('Офсетная'),
('Цифровая'),
('Цифровая офсетная'),
('Металлографическая'),
('Флексографическая'),
('Сублимационная'),
('Шелкографическая'),
('Литографическая'),
('Тампонная'),
('Ирисовая'),
('Орловская');
go
insert into [material]
values
('Матовая бумага'),
('Полуглянцевая бумага'),
('Сатиновая бумага'),
('Самоклейка'),
('Пластик'),
('Пленка'),
('Картон'),
('Фотобумага'),
('Мелованная бумага'),
('Мелованный картон'),
('Глянцевая бумага');
go
insert into [vid_oplat]
values
('Безналичная оплата'),
('Оплата наличными');
go
insert into [maket]
values
('Plakat','Файл "JPG" (.jpg)','143 КБ','444 x 645','24','21.02.2021','21.02.2021'),
('Visitka','Файл "PNG" (.png)','60,1 КБ','300 x 167','32','21.02.2021','21.02.2021'),
('Priglashenia','Файл "JPG" (.jpg)','187 КБ','1459 x 994','24','21.02.2021','21.02.2021'),
('Otkritka','Файл "JPG" (.jpg)','333 КБ','900 x 1200','24','21.02.2021','21.02.2021'),
('Konvert','Файл "JPG" (.jpg)','29,3 КБ','800 x 387','24','21.02.2021','21.02.2021');
go
insert into [prodykcia]
values
(1,3,420,594,5,8,'319'),
(3,12,90,50,10,10,'35'),
(3,16,210,297,5,7,'130'),
(3,15,148,105,5,7,'75'),
(3,20,229,324,5,1,'32');
go
insert into [klienti]
values
('Алексеев Константин Фёдорович','410039, г. Саратов, ул. Медиков, дом 108, квартира 907','+7(978)019-95-44','wozalehatte-5071@yopmail.com',2,'','','608628000437','',1),
('Беляев Сергей Макарович','410039, г. Саратов, ул. Академика, дом 89, кв 196','+7(953)013-93-66','lomacideni-9645@yopmail.com',2,'','','859917152460','',1),
('Орлов Владимир Даниилович','410039, г. Саратов, ул. Дупская, дом 134, кв. 331','+7(934)824-80-55','yjykuppa-6925@yopmail.com',2,'','','095570559157','',1),
('Краснова Василиса Марковна','410039, г. Саратов, ул. Руда, дом 23, кв. 27','+7(974)283-02-35','lijetassove-4284@yopmail.com',2,'','','918138559968','',1),
('Черный Михаил Петрович','410039, г. Саратов, ул. Леснода, дом 124, кв. 862','+7(906)601-07-77','ugecigi-1779@yopmail.com',2,'','','396496349908','',1);
go
insert into [zakazi]
values
(1,1,'22.02.2021','0',2,'0',1,'15'),
(2,2,'22.02.2021','0',2,'0',2,'50'),
(3,3,'22.02.2021','0',2,'0',3,'20'),
(4,4,'22.02.2021','0',2,'0',4,'10'),
(5,5,'22.02.2021','0',2,'0',5,'20');
go
insert into [sostoianie_gotovnosti_zakaza]
values
(1,1,'25.02.2021',7),
(2,2,'27.02.2021',7),
(3,3,'24.02.2021',7),
(4,4,'23.02.2021',7),
(5,5,'24.02.2021',7);
go
