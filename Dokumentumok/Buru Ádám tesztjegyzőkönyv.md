 | Teszteset               | Elvárt eredmény                                                                                                     | 
 |-------------------------|---------------------------------------------------------------------------------------------------------------------| 
 | Helytelen adat megadása | A művelet nem hajtódik végre. Üzenetben jelezni a felhasználónak, hogy miért és milyen adatok megadásával történhet.|
 | Helyes adat megadása    | Megtörténik a művelet.| 

#### Ezeket a teszteseteket végrehalyatani a legtöbb kombinációval

**Tesztelő:** Buru Ádám

**Tesztelés dátuma:** 2023.október.10.

| Tesztszám | Rövid leírás                     | Várt eredmény                                                                   | Eredmény                                                                       | Megjegyzés                |
|-----------|----------------------------------|---------------------------------------------------------------------------------|--------------------------------------------------------------------------------|---------------------------|
| Teszt #01 | Főmenű, Játék saját számokkal játékmód kiválasztása | A jelenlegi ablak bezáródik, új ablakban megnyílik a sajátszámos oldal. | A jelenlegi ablak bezáródik, új ablakban megnyílik a sajátszámos oldal. | Elvártnak megfelelően működik. |
| Teszt #02 | Főmenü, Játék véletlenszerű számokkal játékmód kiválasztása | A jelenlegi ablak bezáródik, új ablakban megnyílik a véletlenszerű számos oldal. | A jelenlegi ablak bezáródik, új ablakban megnyílik a véletlenszerű számos oldal. | Elvártnak megfelelően működik. |
| Teszt #03 | Főmenü, Kilépés gomb | A kilépés gombra kattintva egy új ablakban Nem lehetőséggel visszaléphetünk a főmenübe, Igen lehetőséggel kiléphetünk a programból. | A kilépés gombra kattintva egy új ablakban Nem lehetőséggel visszaléphetünk a főmenübe, Igen lehetőséggel kiléphetünk a programból. | Elvártnak megfelelően működik. |
| Teszt #04 | Sajátszámos oldal számok kiválasztása | A felületen a számokra kattintva, azok ki lesznek jelölve, megváltozik a színük. | A felületen a számokra kattintva, azok ki lesznek jelölve, megváltozik a színük.  | Elvártnak megfelelően működik. |
| Teszt #05 | Sajátszámos oldal 5-nél több szám kijelölésénél hibaüzenet | A program hibaüzenetet dob a felhasználónak, ha 5-nél több számot választ ki. | A program hibaüzenetet dob a felhasználónak, ha 5-nél több számot választ ki. | Elvártnak megfelelően működik. |
| Teszt #06 | Sajátszámos oldal kevesebb számmal sorsolás indítás | A program hibaüzenetet dob a felhasználónak, ha 5-nél kevesebb számmal indít sorsolást. | A program hibaüzenetet dob a felhasználónak, ha 5-nél kevesebb számmal indít sorsolást.  | Elvártnak megfelelően működik. | 
| Teszt #07 | Sajátszámos oldal sorsolás indítása 5 kiválasztott számmal | Elindul a sorsolás, megkapjuk a nyerőszámokat, találatokat és a nyereményt. | Elindul a sorsolás, megkapjuk a nyerőszámokat, találatokat és a nyereményt. | Elvártnak megfelelően működik. |
| Teszt #08 | Új játék gomb | Megnyomva a gombot, eltűnik az eredmény tábla, a játék visszaáll alaphelyzetbe, az egyenlegünk megmarad. | Megnyomva a gombot, eltűnik az eredmény tábla, a játék visszaáll alaphelyzetbe, az egyenlegünk megmarad. | Elvártnak megfelelően működik. |
| Teszt #09 | VISSZA gomb | A gombra kattintva bezáródik a jelenlegi ablak, visszatérünk a főmenübe. | A gombra kattintva bezáródik a jelenlegi ablak, visszatérünk a főmenübe. | Elvártnak megfelelően működik. |
| Teszt #10 | Véletlenszámos oldal Random számok kérése gomb | Véletlenszerűen kiválaszt 5 számot és kijelöli őket. | Véletlenszerűen kiválaszt 5 számot és kijelöli őket. | Elvártnak megfelelően működik. |
| Teszt #11 | Véletlenszámos oldal sorsolás indítása Random számok kérése gomb megnyomása nélkül | Ha a random számok kérése nélkül indítaná el a sorsolást a felhasználó, hibaüzenetet kap. | Ha a random számok kérése nélkül indítaná el a sorsolást a felhasználó, hibaüzenetet kap. | Elvártnak megfelelően működik. |
| Teszt #12 | Véletlenszámos oldal Random számok kérése gomb megnyomása egymás után többször | Ha a Random számok kérése gombot egymás után többször megnyomja a felhasználó, mindig új számok lesznek véletlenszerűen kiválasztva. | Ha a Random számok kérése gombot egymás után többször megnyomja a felhasználó, mindig új számok lesznek véletlenszerűen kiválasztva. | Elvártnak megfelelően működik. |
