### Tesztjegyzőkönyv

**Tesztelő:** Fidrus Bence

**Tesztelés dátuma:** 2024.10.08.

Tesztszám | Rövid leírás | Várt eredmény | Eredmény | Megjegyzés
----------|--------------|---------------|----------|-----------
Teszt #01 | Login oldal betöltés | A weboldal helyes megjelenése (szövegmező, gomb, stílus...)  | Sikeres teszt | -
Teszt #02 | Login oldal üres szövegmező esetén | Az oldal nem enged tovább, kötelező nevet megadni | Nem engedett tovább, sikeres | -
Teszt #03 | Belépés az üzenő felületre | Név megadása és Tovább gomb megnyomása után az üzenő felület betöltése | Sikeresen betöltött | -
Teszt #04 | Üres üzenet küldése | Üres üzenetet nem lehet elküldeni, kötelező írni valamit | Sikeres | -
Teszt #05 | Üzenet küldése | Üzenet beírása és a Küldés gomb megnyomása után az üzenet mentésre kerül | Üzenet mentve, sikeres | -
Teszt #06 | Új belépéskor előző üzenetek betöltése | Újabb belépéskor az előzőleg elmentett üzenetek betöltése | Betöltve, sikeres | -
Teszt #07 | Spamelés kezelése | Az egymás után nagyon gyorsan küldött üzenetek kezelése (threading) | Sikeres teszt | -