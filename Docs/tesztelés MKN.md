
### Tesztesetek

**Tesztelő:** Müller Krisztián Norbert

**Tesztelés dátuma:** 2024.10.09

Tesztszám | Rövid leírás | Várt eredmény | Eredmény | Megjegyzés
----------|--------------|---------------|----------|-----------
Teszt #01 | dotnet run | Elindul a szerver | Elindult a szerver. | Az eredmény megegyezik az elvártakkal.
Teszt #02 | Robusztus működés | A szerver váratlan kérések hatására sem crashel |  | Az eredmény megegyezik az elvártakkal.
Teszt #04 | Adatobjektumok JSONná formázása | Az adatobjektumok szabályos JSONná formázódnak ToJson hatására | Az adatobjektumok szabályos JSONná formázódtak ToJson hatására. | Az eredmény megegyezik az elvártakkal.
Teszt #05 | Adatobjektumok létrehozása JSONból | Az adatobjektumok szabályos JSONból helyesen létrejönnek | Az adatobjektumok szabályos JSONból helyesen létrejöttek. | Az eredmény megegyezik az elvártakkal.
Teszt #06 | Statikus állományok kiszolgálása | A szerver kiszolgálja a www, és csak a www mappából a fájlokat | Az index.html-t és társait kiszolgálja, amit pedig nem kéne (pl. /etc/passwd), még gonosz kérések után se. | Az eredmény megegyezik az elvártakkal.
Teszt #07 | messages.json | Leállás után a kimentett adatok megtalálhatóak a messages.json-ban | Leállás után a kimentett adatok megtalálhatóak voltak a messages.json-ban. | Az eredmény megegyezik az elvártakkal.
