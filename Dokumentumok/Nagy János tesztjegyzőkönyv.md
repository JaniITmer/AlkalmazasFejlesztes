 | Teszteset               | Elvárt eredmény                                                                                                     | 
 |-------------------------|---------------------------------------------------------------------------------------------------------------------| 
 | Helytelen adat megadása | A művelet nem hajtódik végre. Üzenetben jelezni a felhasználónak, hogy miért és milyen adatok megadásával történhet.|
 | Helyes adat megadása    | Megtörténik a művelet.                                                                                              | 
 

#### Ezeket a teszteseteket végrehajtani a legtöbb kombinációval

**Tesztelő:** Nagy János

**Tesztelés dátuma:** 2023.október.10.

| Tesztszám | Rövid leírás                     | Várt eredmény                                                                   | Eredmény                                                                       | Megjegyzés                |
|-----------|----------------------------------|---------------------------------------------------------------------------------|--------------------------------------------------------------------------------|---------------------------|
| Teszt #01 | -Véletlenszámos oldal- Random szám kérése gomb többszöri benyomása egymás után | A megfelelő gombok maradnak az oldalon és nem generál 5-től több számot | Minden gomb a helyén maradt és a számok háttere megfelelően megváltozott gombnyomásra| Nem találtam problémát.   |
| Teszt #02 | -Véletlenszámos oldal-  Sorsolás gomb random számok nélkül | A nyerő számok generálása végbemegy, de nem lesz találat   | Megjelenő ablak figyelmezteti a felhasználót, hogy kattintson a random számok generálása gombra                                                       | Nem találtam problémát. |
| Teszt #03 | -Véletlenszámos oldal-  Vissza gombra kattintáskor az adatok nem frissülnek | Az elmentett adatok új játék indításakor törlődnek   | Az adatok sikeresen törlődtek az vissza gomb benyomásakor                                                        | Nem találtam problémát. |                                     
| Teszt #04 | -Véletlenszámos oldal- Az egyenleg helyes megjelenítése | Az egyenleg megfelelően jelenik meg  az oldalon  | A megfelelő összeg jelent meg az oldalon                                                      | Nem találtam problémát. |    
| Teszt #05 | -Véletlenszámos oldal-  Vissza gomb használata | A vissza gomb megnyomásakor a veletlenszamos oldal eltűnik és megjelenik a kezdőoldal | A vissza gomb megnyomásakor a veletlenszamos oldal eltűnik és megjelenik a kezdőoldal                                                     | Nem találtam problémát. | 
| Teszt #06 | -Főmenü- Játék véletlenszerű számokkal gomb használata| Megfelelően megnyílik a véletlenszámos sorsoló oldal |        Megfelelően megnyílik a véletlenszámos sorsoló oldal                                              | Nem találtam problémát. | 
                                                  



