Use [Typography]
go
CREATE VIEW SOS_GOT_ZAK
AS
(
SELECT        dbo.sostoianie_gotovnosti_zakaza.kod_zakaza AS [Код заказа], dbo.klienti.fio AS [ФИО клиента], dbo.sostoianie_gotovnosti_zakaza.data_gotovnosti AS [Дата готовности], dbo.sostoianie_zakaza.sostoanie_zakaza AS [Состояние заказа]
FROM            dbo.klienti INNER JOIN
                         dbo.sostoianie_gotovnosti_zakaza ON dbo.klienti.kod_klienta = dbo.sostoianie_gotovnosti_zakaza.kod_klienta INNER JOIN
                         dbo.sostoianie_zakaza ON dbo.sostoianie_gotovnosti_zakaza.kod_sostoiania_zakaza = dbo.sostoianie_zakaza.kod_sostoiania_zakaza
)

Use [Typography]
go
CREATE VIEW PROD
AS
(
SELECT        dbo.prodykcia.kod_prodykcii AS [Код продукции], dbo.yslygi.naimenovanie_yslygi AS [Наименование услуги], dbo.naimenovanie_prodykcii.naimenovanie_prodykcii AS [Наименование продукции], 
                         dbo.prodykcia.shirina AS Ширина, dbo.prodykcia.visota AS Высота, dbo.vid_pechati.vid_pechati AS [Вид печати], dbo.material.material AS Материал, dbo.prodykcia.stoimost AS Стоимость
FROM            dbo.material INNER JOIN
                         dbo.prodykcia ON dbo.material.kod_materiala = dbo.prodykcia.kod_materiala INNER JOIN
                         dbo.naimenovanie_prodykcii ON dbo.prodykcia.kod_naimenovania_prodykcii = dbo.naimenovanie_prodykcii.kod_naimenovania_prodykcii INNER JOIN
                         dbo.vid_pechati ON dbo.prodykcia.kod_vida_pechati = dbo.vid_pechati.kod_vida_pechati INNER JOIN
                         dbo.yslygi ON dbo.prodykcia.kod_yslygi = dbo.yslygi.kod_yslygi
)


Use [Typography]
go
CREATE VIEW ZAKAZZ
AS
(
SELECT        dbo.zakazi.kod_zakaza AS [Код заказа], dbo.naimenovanie_prodykcii.naimenovanie_prodykcii AS [Наименование продукции], dbo.klienti.fio AS [ФИО клиента], dbo.zakazi.data_zakaza AS [Дата заказа], 
                         dbo.zakazi.dizainer AS Дизайнер, dbo.vid_oplat.vid_oplat AS [Вид оплаты], dbo.zakazi.scidka AS Скидка, dbo.maket.naimenovanie AS [Наименование макета], dbo.zakazi.kolichestvo AS Количество
FROM            dbo.klienti INNER JOIN
                         dbo.zakazi ON dbo.klienti.kod_klienta = dbo.zakazi.kod_klienta INNER JOIN
                         dbo.maket ON dbo.zakazi.kod_maketa = dbo.maket.kod_maketa INNER JOIN
                         dbo.prodykcia ON dbo.zakazi.kod_prodykcii = dbo.prodykcia.kod_prodykcii INNER JOIN
                         dbo.vid_oplat ON dbo.zakazi.kod_vida_oplat = dbo.vid_oplat.kod_vida_oplat INNER JOIN
                         dbo.naimenovanie_prodykcii ON dbo.prodykcia.kod_naimenovania_prodykcii = dbo.naimenovanie_prodykcii.kod_naimenovania_prodykcii
)


Use [Typography]
go
CREATE VIEW KL
AS
(
SELECT        dbo.klienti.kod_klienta AS [Код клиента], dbo.klienti.fio AS ФИО, dbo.klienti.adres AS Адрес, dbo.klienti.tel AS Телефон, dbo.klienti.email AS [E-mail], dbo.vid_zakazchika.vid_zakazchika AS [Вид заказчика], 
                         dbo.klienti.naimenovanie_organizacii AS [Наименование организации], dbo.klienti.iuridicheski_adres AS [Юридический адрес], dbo.klienti.INN_KPP AS [ИНН/КПП], dbo.klienti.raschetni_schet AS [Расчетный счет], 
                         dbo.klienti.nalichie_maketa AS [Наличие макета]
FROM            dbo.klienti INNER JOIN
                         dbo.vid_zakazchika ON dbo.klienti.kod_vida_zakazchika = dbo.vid_zakazchika.kod_vida_zakazchika
)
