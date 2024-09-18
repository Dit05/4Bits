# Követelmény specifikáció

## 1. Áttekintés

Az alkalmazás célja webes kommunikációs felület biztosítása párhuzamosan, több felhasználó részére. A platform közönséges webböngészővel elérhető bármilyen internethasználatra képes eszközről. A felhasználók bejelentkezés nélkül, egyszerűen tudnak egymásnak üzenetet küldeni csupán egy névvel ellátva. Nem kell jelszavakat észben tartani, hiszen a felhasználóknak nem kell attól tartani, hogy valaki más megszerzi az illető bejelentkezési adatait. Az oldal automatikusan kiírja a legújabb üzeneteket és azok posztolóit.

## 2. A jelenlegi helyzet leírása

A világon nincs elég üzenetküldő rendszer. Ezért alakítunk ki egy új, szöveges üzenetküldő platformot, amelyet bárki üzemeltethet. A legtöbb létező csevegő zárt, működtetni kizárólag a fejlesztő cég tudja. Ez rossz, mert ha ők csődbe mennek, akkor kapcsolati hálók, barátságok, házasságok szűnhetnek meg. A 4Bits kommunikátor alkalmazása helyileg elmenti egyszerű, szöveges formátumban a beszélgetést, így a rendszer esetleges bukása esetén az könnyen átvihető máshova.

## 3. Vágyálomrendszer

A projekt célja egy olyan weboldal, amely üzenetváltásra alkalmas különböző felhasználók között. A felhasználónak be kell írnia a nevét, majd az üzenetet amit el szeretne küldeni. A nevet a weboldal megjegyzi
és onnantól bármennyi üzenetet írhat a felhasználó.

## 4. Funkcionális követelmények

## 5. Rendszerre vonatkozó törvények, szabványok, ajánlások

## 6. Jelenlegi üzleti folyamatok modellje

## 7. Igényelt üzleti folyamatok

## 8. Követelménylista

| Id | Modul | Név | Leírás |
| :---: | --- | --- | --- |
| K1 | Backend | Business osztályok definiálása | Az üzeneteket, csevegést ábrázoló típusok nyílvános felületének meghatározása. |
| K2 | Backend | Business osztályok kifejtése | A K1-ben meghatározott osztályok belső működése. |
| K3 | Backend | Csevegés mentése és betöltése | A csevegés mentődjön el egy szövegfájlba amikor a szerver leáll, és töltődjön be amikor elindul. |
| K4 | Backend | HTTP kiszolgáló | A szerveralkalmazás képes legyen kiszolgálni böngészőket a meghatározott erőforrásokkal. |

## 9. Riportok

## 10. Fogalomtár
