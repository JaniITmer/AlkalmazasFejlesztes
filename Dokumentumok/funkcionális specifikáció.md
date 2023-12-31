# Funkcionális specifikáció
## 1. Jelenlegi helyzet leírása
A cél egy olyan szoftver létrehozása, ami a szerencsejátékozás élményét nyújtja ingyenes, kockázatmentes formában. Két különböző szimulációt biztosít, az egyik egy véletlenszerűen generált, a másik egy saját számokkal való játék. Fontos a könnyű kezelhetőség, a figyelemfelkeltő megjelenés, a lehető legjobb hozzáférhetőség érdekében.

## 2. Vágyálomrendszer leírása
A program betöltésekor a felhasználót egy főmenü fogadja, ahol 3 funkció közül választhat: Szimuláció Véletlen Számokkal, Szimuláció Saját Számokkal, Kilépés. A véletlen számokkal való játék esetén egy olyan felület jelenik meg, ahol a felső sorban a nyerő számok szerepelnek, az alatta lévő sorban pedig a játékosnak generált számok. Amennyiben a saját számokkal való szimulációt válasszuk, megadhatjuk a számokat, amikkel játszani szeretnénk, majd elindítjuk a szimulációt. A sorsolás után megkapjuk a nyerő számokat, a találatok számát, illetve a nyeremény összegét.

## 3. Jelenlegi üzleti folyamatok modellje
Napjainkban egyre csak nő a szerencsejáték függők száma. Ez részben annak is köszönhető, hogy nagyon sok mobilra fejlesztett játék jutalmazó rendszere gyorsan megszerezhető, kisebb nyereményekkel halmozza el a felhasználót. Egy idő után viszont már ez nem lesz elég, mindig egyre csak többet és többet akar az ember, majd a saját pénzét is erre költi. A mi alkalmazásunk célja, hogy a felhasználó ugyanúgy jutalmazva legyen, de anélkül, hogy adósságokba sodorná magát.

## 4. Igényelt üzleti folyamatok modellje
A függőség megelőzésére, illetve megkönnyítésére egy olyan szoftvert tervezünk megvalósítani, ami ingyenesen adja át a szerencsejátékozás élményét, ezenkívül figyelemfelhívó szerepe is van ennek a szenvedélynek a veszélyeire. A program nem igényel internet kapcsolatot, az elkészítésnél igyekszünk az egyszerű és figyelemfelkeltő kezelőfelület megvalósítására, hogy minél több felhasználó számára legyen elérhető.

## 5. Követelménylista

| Id | Modul | Név | Leírás |
| :---: | --- | --- | --- |
| K1 | Főmenü | Design, Gombok elhelyezése | Könnyen kezelhető, figyelemfelkeltő főmenü |
| K2 | Főmenü | Választófelület | Szimuláció típus kiválasztása |
| K3 | Szimuláció | Design | Szimuláció design kialakítása |
| K4 | Szimuláció | Szimuláció véletlenszerű számokkal | Ötös lottó számhúzó szimulációja véletlenszerű számokkal |
| K5 | Szimuláció | Szimuláció saját számokkal | Ötös lottó számhúzó szimulációja saját számokkal |
| K6 | Szimuláció | Találatok száma kiírás | Eltalált számok alapján találatok kiírása |
| K7 | Szimuláció | Nyeremény kiírás | Eltalált számok alapján nyeremény kiírása |

## 6. Használati esetek
A szoftvert bármelyik korosztály használhatja. A fiatalok esetében, főleg a nyeremény mennyisége, a találatok száma és a szimuláció lehet szórakoztató. A felnőtteknél, inkább a saját számokkal való szerencse próbálgatása a szórakoztató, hogy mennyire bírják eltalálni a számokat, mely nem is annyira egyszerű. Végül az idősebb korosztálynál pedig maga a kezelőfelület és a játék bonyolultsága miatt lehet vonzó.

## 7. Terjedelem
A programunk megközelítőleg 400 és 500 sor közé tehető.
