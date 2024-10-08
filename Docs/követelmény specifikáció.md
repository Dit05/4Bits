# Követelmény specifikáció

## 1. Áttekintés

Az alkalmazás célja webes kommunikációs felület biztosítása párhuzamosan, több felhasználó részére. A platform közönséges webböngészővel elérhető bármilyen internethasználatra képes eszközről. A felhasználók bejelentkezés nélkül, egyszerűen tudnak egymásnak üzenetet küldeni csupán egy névvel ellátva. Nem kell jelszavakat észben tartani, hiszen a felhasználóknak nem kell attól tartani, hogy valaki más megszerzi az illető bejelentkezési adatait. Az oldal automatikusan kiírja a legújabb üzeneteket és azok posztolóit.

## 2. A jelenlegi helyzet leírása

A világon nincs elég üzenetküldő rendszer. Ezért alakítunk ki egy új, szöveges üzenetküldő platformot, amelyet bárki üzemeltethet. A legtöbb létező csevegő zárt, működtetni kizárólag a fejlesztő cég tudja. Ez rossz, mert ha ők csődbe mennek, akkor kapcsolati hálók, barátságok, házasságok szűnhetnek meg. A 4Bits kommunikátor alkalmazása helyileg elmenti egyszerű, szöveges formátumban a beszélgetést, így a rendszer esetleges bukása esetén az könnyen átvihető máshova.

## 3. Vágyálomrendszer

A projekt célja egy olyan weboldal, amely üzenetváltásra alkalmas különböző felhasználók között. A felhasználónak be kell írnia a nevét, majd az üzenetet amit el szeretne küldeni. A nevet a weboldal megjegyzi
és onnantól bármennyi üzenetet írhat a felhasználó.

## 4. Jelenlegi üzleti folyamatok modellje
Mai világban a kommunikáció tartására számtalan megoldás lehetséges.Megrendelőnk kérése számunkra az volt,hogy segítsünk neki egy olyan chat weboldalt készíteni amivel később más cég vetélytársa lehet mint például Messenger,Telegram.Bejelentkezés nélkül egy felhasználónév megadásával tud beszélgetni bárkivel a világon.Egyszerűsíti és felgyorsítja kapcsolatteremtés regisztrálció nélkül.

## 5. Igényelt üzleti folyamatok modellje
A weboldal egy főoldalból fog állni ahol felhasználónevet kér tőlünk majd ezután enged be a chatfelületre. Itt láthatunk egy üzenetablakot ahol a felhasználók látják a korábbi és aktuális üzeneteket. Görgethető felület,hogy a régebbi üzenetek is elérhetőek legyenek.
Beviteli mezőben (input box) felhasználók beírhatják az üzeneteiket ami egy egyszerű szövegmező.Végül a küldés gomb Az üzenetek elküldésére szolgáló gomb.Felhasználók az Enter gombbal is elküldhetik az üzenetet.

## 6. Követelménylista

| Id | Modul | Név | Leírás |
| :---: | --- | --- | --- |
| K1 | Frontend | Név bekérése | Az oldal felhasználónevet kér. |
| K2 | Frontend | Üzenetek visszaolvasása | Látszik az összes eddigi üzenet. |
| K3 | Frontend | Üzenetküldés | Lehet küldeni üzenetet. |
| K4 | Backend | Üzenetmegmaradás | Az üzenetek el vannak mentve egy json fájlban. |

## 7. Fogalomtár
| Fogalom | Leírás |
| :---: | --- |
| Aszinkron kommunikáció | A felhasználók közötti információcsere anélkül, hogy valós idejű interakcióra lenne szüksége. |
| Reszponzív felület | A felület mérete és az elemek elhelyezkedése alkalmazkodik a böngésző ablakméretéhez |
