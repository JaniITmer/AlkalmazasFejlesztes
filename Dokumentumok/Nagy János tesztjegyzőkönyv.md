 | Teszteset               | Elvárt eredmény                                                                                                     | 
 |-------------------------|---------------------------------------------------------------------------------------------------------------------| 
 | Helytelen adat megadása | A művelet nem hajtódik végre. Üzenetben jelezni a felhasználónak, hogy miért és milyen adatok megadásával történhet.|
 | Helyes adat megadása    | Megtörténik a művelet.                                                                                              | 
 

#### Ezeket a teszteseteket végrehalyatani a legtöbb kombinációval

**Tesztelő:** Nagy János

**Tesztelés dátuma:** 2023.október.10.

| Tesztszám | Rövid leírás                     | Várt eredmény                                                                   | Eredmény                                                                       | Megjegyzés                |
|-----------|----------------------------------|---------------------------------------------------------------------------------|--------------------------------------------------------------------------------|---------------------------|
| Teszt #01 | Random szám kérése gomb többszöri benyomása egymás után | A megfelelő gombok maradnak az oldalon és nem generál 5-től több számot | Minden gomb a helyén maradt és a számok háttere megfelelően megváltozott gombnyomásra| Nem találtam problémát.   |
| Teszt #02 | Sorsolás gomb random számok nélkül | A nyerő számok generálása végbemegy, de nem lesz találat   | Megjelenő ablak figyelmezteti a felhasználót, hogy kattintson a random számok generálása gombra                                                       | Nem találtam problémát. |
| Teszt #03 | Új játék gombra kattintáskor az adatok nem frissülnek | Az elmentett adatok új játék indításakor törlődnek   | Az adatok sikeresen törlődtek az új játék gomb benyomásakor                                                        | Nem találtam problémát. |                                     
