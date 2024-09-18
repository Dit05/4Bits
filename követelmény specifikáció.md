# Követelmény specifikáció

## 1. Áttekintés

Az alkalmazás célja webes kommunikációs felület biztosítása párhuzamosan, több felhasználó részére. A platform közönséges webböngészővel elérhető bármilyen internethasználatra képes eszközről. A felhasználók bejelentkezés nélkül, egyszerűen tudnak egymásnak üzenetet küldeni csupán egy névvel ellátva. Nem kell jelszavakat észben tartani, hiszen a felhasználóknak nem kell attól tartani, hogy valaki más megszerzi az illető bejelentkezési adatait. Az oldal automatikusan kiírja a legújabb üzeneteket és azok posztolóit.

## 2. A jelenlegi helyzet leírása

A világon nincs elég üzenetküldő rendszer. Ezért alakítunk ki egy új, szöveges üzenetküldő platformot, amelyet bárki üzemeltethet. A legtöbb létező csevegő zárt, működtetni kizárólag a fejlesztő cég tudja. Ez rossz, mert ha ők csődbe mennek, akkor kapcsolati hálók, barátságok, házasságok szűnhetnek meg. A 4Bits kommunikátor alkalmazása helyileg elmenti egyszerű, szöveges formátumban a beszélgetést, így a rendszer esetleges bukása esetén az könnyen átvihető máshova.

## 3. Vágyálomrendszer

A projekt célja egy olyan weboldal, amely üzenetváltásra alkalmas különböző felhasználók között. A felhasználónak be kell írnia a nevét, majd az üzenetet amit el szeretne küldeni. A nevet a weboldal megjegyzi
és onnantól bármennyi üzenetet írhat a felhasználó.

<<<<<<< HEAD
## 4. Funkcionális követelmények


## 5. Rendszerre vonatkozó törvények, szabványok, ajánlások

## 6. Jelenlegi üzleti folyamatok modellje
Mai világban a kommunikáció tartására számtalan megoldás lehetséges.Megrendelőnk kérése számunkra az volt,hogy segítsünk neki egy olyan chat weboldalt készíteni amivel később más cég vetélytársa lehet mint például Messenger,Telegram.Bejelentkezés nélkül egy felhasználónév megadásával tud beszélgetni bárkivel a világon.Egyszerűsíti és felgyorsítja kapcsolatteremtés regisztrálció nélkül.

## 7. Igényelt üzleti folyamatok modellje
A weboldal egy főoldalból fog állni ahol felhasználónevet kér tőlünk majd ezután enged be a chatfelületre. Itt láthatunk egy üzenetablakot ahol a felhasználók látják a korábbi és aktuális üzeneteket. Görgethető felület,hogy a régebbi üzenetek is elérhetőek legyenek.
Beviteli mezőben (input box) felhasználók beírhatják az üzeneteiket ami egy egyszerű szövegmező.Végül a küldés gomb Az üzenetek elküldésére szolgáló gomb.Felhasználók az Enter gombbal is elküldhetik az üzenetet.
=======
## 4. Jelenlegi üzleti folyamatok modellje
Mai világban a kommunikáció tartására számtalan megoldás lehetséges.Megrendelőnk kérése számunkra az volt,hogy segítsünk neki egy olyan chat weboldalt készíteni amivel később más cég vetélytársa lehet mint például Messenger,Telegram.Bejelentkezés nélkül egy felhasználónév megadásával tud beszélgetni bárkivel a világon.

## 5. Igényelt üzleti folyamatok modellje
>>>>>>> 3e9456c4241b1375f27a5dfd4a27fa97054063b2

## 6. Követelménylista

| Id | Modul | Név | Leírás |
| :---: | --- | --- | --- |
| K1 | Backend | Business osztályok definiálása | Az üzeneteket, csevegést ábrázoló típusok nyílvános felületének meghatározása. |
| K2 | Backend | Business osztályok kifejtése | A K1-ben meghatározott osztályok belső működése. |
| K3 | Backend | Csevegés mentése és betöltése | A csevegés mentődjön el egy szövegfájlba amikor a szerver leáll, és töltődjön be amikor elindul. |
| K4 | Backend | HTTP kiszolgáló | A szerveralkalmazás képes legyen kiszolgálni böngészőket a meghatározott erőforrásokkal. |

## 7. Fogalomtár

Aszinkron kommunikáció - A felhasználók közötti információcsere anélkül, hogy valós idejű interakcióra lenne szüksége.

