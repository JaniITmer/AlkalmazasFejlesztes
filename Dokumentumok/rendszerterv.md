# Rendszerterv
## 1. A rendszer célja


A rendszer célja, hogy szórakoztassa a felhasználókat korosztálytól függetlenül. Lehet választani véletlenszerű és saját számokkal való szimulációk közül. Tervünk szerint ezzel csökkenthetjük a függőség kialakulásának a valószínűségét. Ahelyett hogy az emberek egy nyerés-vesztés körfogásba kerülnének és csak ki akarnák próbálni a szerencséjüket, egyszerűen csak elindítják a szoftvert és játszanak vele. Így úgy tesztelhetik a szerencséjüket, hogy bármilyen pénzt is költeniük kéne, így a káros körforgás teljesen kimarad.

## 2. Projektterv

A rendszer létrehozásához rendelkezésre álló erőforrások:
A felhasználó által használt notebookok/asztali számítógépek melyeknek rendelkezniük kell egy futó opercációs rendszerrel(Windows 10/11, Linux)

   - Scrum Masters: Katona Bálint Sándor
   - Product Owner: Katona Bálint Sándor, Buru Ádám, Guba Ádám, Juhász Gergő, Nagy János
   - Contributer: Buru Ádám
   - Contributer: Guba Ádám
   - Contributer: Juhász Gergő
   - Contributer: Nagy János
   - Megrendelő: Bagoly Gábor

## 3. Résztvevők és főbb szereplők:
- Buru Ádám: A program fejlesztése, tesztelése.
- Guba Ádám: A program fejlesztése, tesztelése.
- Juhész Gergő: A program fejlesztése, tesztelése.
- Nagy János: A program fejlesztése, tesztelése
- Katona Bálint Sándor: A fejlesztés felülvizsgálása.
## 4. Mérföldkövek:
 - Feladatok kiosztása megegyezés és tudás szerint.
 - Dokumentációk, leírások képernyő tervek véglegesítése.
 - Git repo folyamatos frissítése amikor akármi elkészül.
 - Folyamatos kommunikáció a projektben résztvevőkkel.
 - Tesztelési folyamatok befejezése.
 - Felkészülés a projekt bemutatására.
 - Bemutatás.

 ## 5. Funkcionális terv
Futtatás után egy kezelőfelület jelenik meg, ahol 3 menüpont fogad. Egy szimuláció véletlen számokkal, egy szimuláció saját számokkal és egy kilépés gomb. Mind a véletlen, mind a saját számos szimulációnál egy új ablak jelenik meg, ahol a felső sorban a "kihúzott" számok vannak, és az alsó sorban pedig a játékos számai. Saját számos generálásnál a játékosnak kell beírni az általa választott számokat és csak utánna tudja szimulálni a húzásokat. Minden húzás után a találatok száma alapján kiír egy nyeremény összeget.

## 6. Fizikai terv
### Futtatás módja:
- Minden számítógépen lokálisan fut majd
### Futtató környezet:
- .NET Framework
### Elérhető operációs rendszerek:
- Windows 8.1
- Windows 10
- Windows 11
### Szoftver moduljai:
- A szoftvert két Windows Form Application tesz össze
### Fejlesztői környezet:
- Visual Studio C#

## 7. Teszt terv
A tesztelések célja a rendszer és komponensei funkcionalitásának teljes vizsgálata, ellenőrzése, a rendszer által megvalósított üzleti szolgáltatások verifikálása. Mi főleg a fejlesztői tesztekre fogunk fókuszálni.
#### Tesztelendő funkciók
 - Működnie kell a gomboknak a főmenüben
 - Sikeresen le kell generálni 5 véletlen számot
 - Saját számos szimulációnál nem lehetnek üresek a mezők
 - Találatok számát jól meg kell számolni

## 8. Telepités
A programot Githubon keresztül lehet telepíteni miután elvégeztük a letöltést ([A letöltéshez segítség])((https://crast.net/150687/downloading-files-from-github-is-very-simple-this-is-how-you-can-do-it-from-your-mobile-or-pc "Segítség a letöltéshez")) utánna ki bontjuk a mappát oda ahová szeretnénk.
