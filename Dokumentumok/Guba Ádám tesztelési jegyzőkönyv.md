 | Teszteset               | Elvárt eredmény                                                                                                     | 
 |-------------------------|---------------------------------------------------------------------------------------------------------------------| 
 | Helytelen adat megadása | A művelet nem hajtódik végre. Üzenetben jelezni a felhasználónak, hogy miért és milyen adatok megadásával történhet.|
 | Helyes adat megadása    | Megtörténik a művelet.                                                                                              | 

#### Ezeket a teszteseteket végrehalyatani a legtöbb kombinációval

**Tesztelő:** Guba Ádám

**Tesztelés dátuma:** 2023.október.10.

| Tesztszám | Rövid leírás                     | Várt eredmény                                                                   | Eredmény                                                                       | Megjegyzés                |
|-----------|----------------------------------|---------------------------------------------------------------------------------|--------------------------------------------------------------------------------|---------------------------|
| Teszt #01 | Véletlenszámos oldal - random számok generálása | Random számok generálása 1-90-ig, a számok megjelölése a táblázatban. | 5 véletszerű számot jelöl meg. | Nem találtam problémát.   |
| Teszt #02 | Véletlenszámos oldal -  sorsolás indítása | Nyerőszámok, a felhasználó számainak megjelenítése egy külön ablakban. | A gombra kattintva megjelennek a nyerőszámok és a felhasználó számai valamint a nyert összeg.| A program jól megjeleníti az adatokat egy külön ablakban. Nem találtam hibát.   |
| Teszt #03 | Véletlenszámos oldal -  sorsolás indítása random számok generálása előtt. | Hiba üzenet megjelnítése. | A gombra kattintva egy külön ablakban hiba üzenet jelenik meg a következő felírattal: "kattintson a random számok kérése gombra".| Nem találtam hibát.   |
| Teszt #04 | Vissza gomb tesztelése. | A gombra hatására az előző ablakot jeleníti meg. | A gombra kattintva a Main oldal jelenik meg. | A gomb megfelelően működik a Véletszámos és Sajátszámos oldalon is.   |
| Teszt #05 | Kilépés | Kilépés előtt 2 gombbal megjelenő ablak. | A kilépés gomb hatására egy ablak jelenik meg, ami egy Nem és Igen gombokat tartalmaz| Nem találtam problémát.   |
