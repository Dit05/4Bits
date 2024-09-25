# Rendszerterv
## 1. A rendszer célja
A rendszer célja, hogy a felhasználók egyszerűen és gyorsan tudjanak kommunikálni egymással az online platformon keresztül, illetve hogy egy biztonságos és megbízható kommunikációs csatornát nyújtson számukra.
A rendszer átlátható felülettel rendelkezik és felhasználóbarát. A platform elérhető weben és mobil eszközökön keresztül, ezáltal a
felhasználók bármikor hozzáférhetnek a rendszerhez.
## 2. Projektterv

### 2.1 Projektszerepkörök, felelőségek:
   * Scrum masters: Müller Krisztián, Kiss Gergő, Fidrus Bence, Rácz Levente
   * Product owner: Müller Krisztián, Kiss Gergő, Fidrus Bence, Rácz Levente
   * Üzleti szereplő: Müller Krisztián, Kiss Gergő, Fidrus Bence, Rácz Levente
     
### 2.2 Projektmunkások és felelőségek:
   * Frontend: Kiss Gergő, Rácz Levente
   * Feladatuk a főoldal megtervezése HTML és CSS-ben. Az API-ból érkező adatok leklérése és kiiratása a weboldalon Javascript segítségével.
   * Backend: Müller Krisztián, Fidrus Bence
   * Feladatuk a business osztályok definiálása és kifejtése, csevegés mentése és betöltése json fileba. HTTP kiszolgáló megírása
   * Tesztelés: Kiss Gergő, Müller Krisztián, Fidrus Bence, Rácz Levente
     
### 2.3 Ütemterv:

|Funkció                  | Feladat                                | Prioritás | Becslés (nap) | Aktuális becslés (nap) | Eltelt idő (nap) | Becsült idő (nap) |
|-------------------------|----------------------------------------|-----------|---------------|------------------------|------------------|---------------------|
|Követelmény specifikáció |Megírás                                 |         1 |             1 |                      1 |                1 |                   1 |             
|Funkcionális specifikáció|Megírás                                 |         1 |             1 |                      1 |                1 |                   1 |
|Rendszerterv             |Megírás                                 |         1 |             1 |                      1 |                1 |                   1 |
|Program                  |Képernyőtervek elkészítése              |         2 |             1 |                      1 |                1 |                   1 |
|Program                  |Prototípus elkészítése                  |         4 |             8 |                      8 |                8 |                   8 |
|Program                  |Alapfunkciók elkészítése                |         4 |             8 |                      8 |                8 |                   8 |
|Program                  |Tesztelés                               |         4 |             2 |                      2 |                2 |                   2 |

### 2.4 Mérföldkövek:
 - 09.25 Rendszerterv
 - 09.25 Funkcionális specifikáció
 - 09.25 Követelmény specifikáció
 - 10.02 Frontend design megtervezése
 - 10.02 Backend funkciók elkészítése
 - 10.09 API megírása
 - 10.09 Frontend javascript kiegészítése
 - 10.16 Tesztelés



## 3. Üzleti folyamatok modellje
1. Dokumentáció megírása, tervek elkészítése
2. Programkód megírása, weboldal elkészítése
   1. Backend
   2. API
   3. Frontend
3. Tesztelés
4. Hibák javítása, utolsó változtatások
5. Termék átadása

## 4. Követelmények

### Funkcionális követelmények

| ID | Megnevezés | Leírás |
| --- | --- | --- |
| K1 | Belépés | A felhasználó egy név segítségével be tud lépni az oldalra |
| K2 | Üzenetek megtekintése | A felhasználó látja az előzőleg, más felhasználók által küldött üzeneteket. |
| K3 | Üzenetet küldése | A felhasználó az általa beírt üzenetet továbbítani tudja a szerver, ezáltal mások felé is. |
| K4 | Business osztályok definiálása | Az üzeneteket, csevegést ábrázoló típusok nyílvános felületének meghatározása. |
| K5 | Business osztályok kifejtése | A K1-ben meghatározott osztályok belső működése. |
| K6 | Csevegés mentése és betöltése | A csevegés mentődjön el egy szövegfájlba amikor a szerver leáll, és töltődjön be amikor elindul. |
| K7 | HTTP kiszolgáló | A szerveralkalmazás képes legyen kiszolgálni böngészőket a meghatározott erőforrásokkal. |
| K8 | Üzenetek fogadása és küldése | A frontend és a backend tudjon információt továbbítani egymásnak |
| K9 | REST API kiépítése | A REST metódusok implementálása |


### Támogatott eszközök

Egy weboldalt terveztünk ami telefonon,tableten és asztali számítógépen is használható internetkapcsolat igénybevételével.

## 5. Funkcionális terv

### 5.1 Rendszerszereplők

- Felhasználó

### 5.2 Menühierarchiák

- Felhasználó
    - Beüthet számjegyeket, betűket, karakterláncokat amit akár ki is tud törölni. Üzenetként elküldheti a többi felhasználó számára, a többiek üzeneteit pedig mindig láthatja.


## 6. Fizikai környezet

### Vásárolt softwarekomponensek és külső rendszerek
A termék nem rendelkezik fizetett, vásárolt komponensekkel.

### Fejlesztő eszközök
- Visual Studio Code / Visual Studio
- ASP.NET Core keretrendszer

## 7. Architekturális terv

### Webszerver

A rendszerhez szükség van egy központi szerverre, melyhez C#-ot használunk. Ez szolgálja ki a webböngészőknek a kliens weblapot, illetve a kliens innen szerzi és ide küldi az adatokat JSON objektumok formájában. A szerver a .NET HttpListener osztálya segítségével kezeli a kliens kéréseit.

### Kliens

A webfelület egy egyszerű HTML és JavaScript alapú oldal, melyet a felhasználó webböngészője a webszervertől szerez meg.

## 8. Adatbázis terv
A rendszerhez nincs szükség külön adatbázis készítésére.Beszélgetések kimentése Json formatumban lehetséges.

## 9. Implementációs terv

A webes felület HTML, CSS, és JavaScript nyelven fog elkészülni. A felület felhasználja a backend API-ját, ami a REST elveket követi. A szerver .NET Core környezetbe fog futni, és C#-ban fog íródni.

## 10. Tesztterv

A tesztelések célja a rendszer és komponensei funkcionalitásának teljes vizsgálata,
ellenőrzése a rendszer által megvalósított üzleti szolgáltatások verifikálása.
A teszteléseket a fejlesztői csapat minden tagja elvégzi.
Egy teszt eredményeit a tagok dokumentálják külön fájlokba.


## 11. Telepítési terv
Mivel weboldal és nem asztali alkalmazás így nem kell telepíteni semmit. Elég ha a számítógép rendelkezik .NET keretrendszerrel.A weboldalt internet hozzáféréssel bármikor el fogja tudni érni. 

## 12. Karbantartási terv

Fontos ellenőrizni:
...

Figyelembe kell venni a felhasználó által jött visszajelzést is a programmal kapcsolatban.
Ha hibát talált, mielőbb orvosolni kell, lehet az:
*	Működéssel kapcsolatos
*	Kinézet, dizájnnal kapcsolatos
