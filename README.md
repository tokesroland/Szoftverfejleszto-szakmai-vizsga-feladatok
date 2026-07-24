# Szoftverfejlesztő és- tesztelő Szakmai vizsga összefoglaló

# Használt tech stack
- C# .NET Windows Forms feladatok.
- C# CLI
- PHP REST API, Form-mos feladatok
- Frontend JS -> Chart.js
- HTML, CSS, Bootstrap
- JavaScript ciklusos tömbkezelés és feladatok

# A vizsgáról
Az írásbeli vizsgarész (240 perces vizsga) ***öt részből áll: Frontend, Backend, Reszponzív weboldal készítése, CLI ÉS GUI Asztali alkalmazás fejlesztése. **

- Frontend: A feladatok azok jelenleg 10. és 11. osztályban szerzett gyakorlati anyagok, frisset nem tudtam biztosítani feltöltésre, de általában a képzésnek ezen része a legkülönbözőbb az intézményeknél. Ideális esetben a képzés során a tanulók megismerkednek legalább egy frontend keretrendszerrel. Ez jellemzően Vue, React, Angular szokott lenni, mivel ezek a legpiacképesebbek jelenleg. 
A ***vizsga frontend feladat része így intézménytől függően eltérő lehet***, de azt is figyelembe kell venni, hogy jelenleg (2025-2026 tanév) ***a tanárok állítják össze a feladatsorokat***, így nem feltétlen kell meglepetésre számítani. A mi esetünkben vanilla JS volt chart.js könyvtárral kellett algoritmizálni, de ***általában inkább komponens alapú és kliensoldai fejlesztésre kell számítani*** (Például, hogy egy megadott api útvonalra tudjunk elérési útvonalat megadni.)
- Backend: A vizsgarész teljes mértékben ***REST API*** írásra szakosodik, ezt a hivatalos követelmények is előírják. Általában a fő cél, hogy API endpointokat írjunk, ami képes JSON file-ból küldeni és fogadni requesteket. ***GET, POST, DELETE, PUT*** method használatával kell tudni ***adatbázisba*** írni vagy lekérdezni adatot. Az egyszerű SQL lekérdezéseket és műveleteket kell hozzá ismerni, ami nem bonyolult, viszont egyeseknél okozhat nehézséget ha összetettebb JOIN lekérdezést is kell írni GET-hez (pl.: Ha a feladat megadja, hogy egy terméket kell lekérdezni ÉS a hozzá tartozó kategóriát is, ami esetleg másik táblában van). PHP, Node.js, ASP.NET szokott a legnépszerűbb választás lenni.
- Reszponzív weboldal készítése: Itt ismerni kell a bootstrap osztályokat, grid systemet és media query használatát, header, footer, table, section osztályok szoktak legtöbbször kérni.
- Asztali alkalmazás fejlesztése (CLI): Ezek típusfeladatokból állnak, nagyon kevés esetben nem hasonló a mintafeladat. A tanulónak képesnek kell lennie: Osztályokat használni és konstruktorral objektumot létrehozni ***beolvasott csv/txt file-ból***, programozási tételeket alkalmazni és algoritmizálni műveleteket az objektumokkal: átlag, min, max, keresés user inputra, file írása, összetett adatszerkezetekbe feltölteni és foreach ciklussal végig futtatni, tehát Dictionary (kulcs-érték) vagy List (dinamikus tömb), esetleg hibajavítás és tesztelés (például: Hibásan kapja meg a vizsgázó a csv file-t). ***Tanterv szerint két nyelv közül oldható meg a vizsga: Java vagy C# .NET***
- Asztali alkalmazás fejlesztése (GUI): Java esetében JavaFX, C# .NET-nél pedig Windows Forms vagy WPF-ben történik a vizsga. Ez is eltérő szokott lenni, de nagyságrendileg képesnek kell lennie a vizsgázónak ListView vagy DataGrid-be beolvasni adatokat és azokat szűrni valamilyen módon, mondjuk Text input mezővel keresni tartalomra, legördülő menüvel kategorizálni. Ha a B feladatrészt kapja a vizsgázó, akkor előfordul, hogy adatbázisba is kell egyszerű CRUD műveleteket (Create, Read, Update, Delet) elvégezni, ezt mi specifikusan MySQL .NET extensionnal csináltuk.

# Az anyagok.
- Hiányosak a feladatok, de tartalmaznak szinte mindent, ami előfordult a ***vizsgámon***, amiket megosztottam és feltöltöttem azok tájékoztató jellegűek, a vizsga menete pedig saját tapasztalatról való beszámolás, nem biztos, hogy mindenhol ugyan ez lesz, de jó iránymutatásnak

