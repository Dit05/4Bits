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
|Program                  |Prototípus elkészítése                  |         3 |             8 |                      8 |                8 |                   8 |
|Program                  |Alapfunkciók elkészítése                |         3 |             8 |                      8 |                8 |                   8 |
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
| K1 | ... | ... |

### Nemfunkcionális követelmények

| ID | Megnevezés | Leírás |
| --- | --- | --- |
| K4 | ... | ... |

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

### Hardver topológia

### Fizikai alrendszerek

### Fejlesztő eszközök


## 7. Architekturális terv

### Webszerver

A rendszerhez szükség van egy központi szerverre, melyhez C#-ot használunk. Ez szolgálja ki a webböngészőknek a kliens weblapot, illetve a kliens innen szerzi és ide küldi az adatokat JSON objektumok formájában. A szerver a .NET HttpListener osztálya segítségével kezeli a kliens kéréseit.

### Kliens

A webfelület egy egyszerű HTML és JavaScript alapú oldal, melyet a felhasználó webböngészője a webszervertől szerez meg.

## 8. Adatbázis terv

## 9. Implementációs terv

## 10. Tesztterv

A tesztelések célja a rendszer és komponensei funkcionalitásának teljes vizsgálata,
ellenőrzése a rendszer által megvalósított üzleti szolgáltatások verifikálása.
A teszteléseket a fejlesztői csapat minden tagja elvégzi.
Egy teszt eredményeit a tagok dokumentálják külön fájlokba.

### Tesztesetek

 | Teszteset | Elvárt eredmény | 
 |-----------|-----------------| 
 | ... | ... |

### A tesztelési jegyzőkönyv kitöltésére egy sablon:

**Tesztelő:** Vezetéknév Keresztnév

**Tesztelés dátuma:** Év.Hónap.Nap

Tesztszám | Rövid leírás | Várt eredmény | Eredmény | Megjegyzés
----------|--------------|---------------|----------|-----------
például. Teszt #01 | Regisztráció | A felhasználó az adatok megadásával sikeresen regisztrálni tud  | A felhasználó sikeresen regisztrált | Nem találtam problémát.
... | ... | ... | ... | ...

## 11. Telepítési terv
Mivel weboldal és nem asztali alkalmazás így nem kell telepíteni semmit. Elég ha a számítógép rendelkezik .NET keretrendszerrel.A weboldalt internet hozzáféréssel bármikor el fogja tudni érni. 

## 12. Karbantartási terv

Fontos ellenőrizni:
...

Figyelembe kell venni a felhasználó által jött visszajelzést is a programmal kapcsolatban.
Ha hibát talált, mielőbb orvosolni kell, lehet az:
*	Működéssel kapcsolatos
*	Kinézet, dizájnnal kapcsolatos
