# Szoftverfejlesztő és- tesztelő Szakmai vizsga összefoglaló

# A tartalomról

Ez egy nagy átfogó tudásbázis mindenről (nagyrészt), ami a szoftverfejlesztő és- tesztelő vizsgáról szól. Vannak itt segédletek, puskák, éles vizsgafeladatok, feladat minták és források.
A részletes leírásokat és forrásokat ezeken a címeken találhatóak, illetve az NSZFH oldaláról szedtem, ahogyan a dokumentumokat is, de vannak saját kreálmányok is.


- Mappa struktúra
- - Frontend_js: Hiányos még, ide kerülnek a frontend gyakorló feladatok. Jelenleg Vanilla JS van benne és chart.js
- - Hivatalos dokumentumok: Itt három hivatalos dokumentum található. Képzési és kimeneteli követelmények, szakvizsga követelmények és programterv, hogy miből kell állnia a képzésnek. (általában PTT-ből állítják össze az interaktív teszt kérdéseit.)
- - Repos: Ide jerülnek a .NET projektet és feladatok. Jelenleg ebben Windows Forms GUI és egyszerű CLI feladatok vannak benne. Ezt a mappát úgy ahogy van bemásolhatod a visual studio repos mappába.
- - Segédletek: Ez az egyik legösszeszedettebb rész, itt találhatóak ***puskák*** backend, frontend, SQL, bármihez és teljes felkészítő anyagokat ***MINDENHEZ***.
- - feladatlap minták: Itt vannak minták, hogy ***milyennek kell kinéznia a szakvizsga írásbeli részének***
- - php_REST_API: Itt PHP backend feladatok vannak, pontosabban REST API megírása natív PHP-ban (Érdemes egyébként Laravelt használni, mert hihetetlenül felgyorsítja a feladat megoldást.)
- - Éles vizsga feladatok: Ide kerülnek éles, különböző forrásokból származő szakvizsga feladatlap ***minták***

# Használt tech stack
- C# .NET Windows Forms feladatok.
- C# CLI
- PHP REST API, Form-mos feladatok
- Frontend JS -> Chart.js
- HTML, CSS, Bootstrap
- JavaScript ciklusos tömbkezelés és feladatok

# Segédletek és források

https://richardkorom.hu/feladatok/vizsga/szakmai-vizsga-gyakorlat/

https://infojegyzet.hu/szakkepzes/szoftverfejleszto/#5

Ezeket a forrásokat tudom legjobban ajánlani gyakorlásra, lefedik jól az egész vizsga menetét.
- A segédletekben vannak HTML dokumentumok, ezeket letöltve duplán kattintva offline megtudjátok nyitni böngészőben és weboldalként nézni, érdemes ezeket használni, rengeteg munkám van bennük és sokat segítettek nekem vizsgára.


# A vizsga részei
A és B részre oszlik a vizsga:

- A: Szoftverfejlesztés elmélete.
 - - Ez elég nagy témaköröket fed le, itt rendesen tisztában kell lenni a szakmai elmélettel. Az infojegyzet.hu oldalon találhattok mintafeladatokat, amelyek viszonylag jól reprezentálják a vizsga menetét. Ez a rész 30 percig tart, teljesen egységesítve van, tehát ország szerte ugyan azt írja mindenki, nem kell tőle megijedni, a legtöbb válasz józan ésszel megoldható ha konyítasz valamelyest a szakmához és figyeltél az órákon. Szerezhetőek részpontok is, vannak több megoldásos válaszok, ha csak tippel az ember, akkor is összehozható legalább 40%, de nyilván ne ez legyen a cél.
- - Kifejezetten ajánlom a segédleteknél az interaktiv_test_felkeszito.html összeállítást, ebben konkrétan MINDEN benne van, ami előfordulhat ezen a vizsgán, Programterv alapján állítottam össze és sokat segített.

- B: Projektmunka védése és írásbeli
- - Az írásbeli vizsgarész (240 perces vizsga) ***öt részből áll: Frontend, Backend, Reszponzív weboldal készítése, CLI ÉS GUI Asztali alkalmazás fejlesztése.*** amelyek leírása lent megtalálható a következő címnél. Ennél a vizsgarésznél lehet internetet használni általános böngészésre. ***Ezt hivatalos NSZFH dokumentum elő is írja, hogy KELL biztósítani internetet korlátozottan.*** Jellemzően W3 schools, hivatalos dokumentációkat, stackoverflow oldalakat ajánlják is, hogy ezeket használni lehet. ***Mással való kommunikációra nem lehet használni***, ebbe elvileg beletartozik a generatív AI is, de ez jelenleg kiskapu / szürkezóna, szóval ez is az intézménytől függ, hogy fejlesztői eszköznek, vagy csalásnak minősítik.
- - Projekt megvédése:
  - - - Ez a legegyszerűbb vizsgarész lényegében, itt egy valós életszerű problémát megoldó szoftvert kell írnijuk ***2 vagy 3 fős csapatban*** a vizsgázóknak és azt kell megvédeni. A pontozási szempontok a segédleteimben és infojegyzet.hu oldalán is megtaláljátok, a ***projektet bemutató prezentációt is érdemes ennek mintájára összeállítani***. Nem kötelező a ppt készítése, de erősen ajánlott, hogy elkerüljük az olyan kellemetlenségeket hogy nem működik valami, ami eddig igen. Erre a problémára a legjobb megoldás a Docker konténerizálásra, ami kiköszöbüli a "nálam működött" problémát, érdemes ránézni mi is ez.
     
# Projekt védés menete
- A vizsgázóknak legalább 5 percig képesnek kell lenniük angolul bemutatni a projektnek a koncepcióját. Itt érdemes a megoldandó problémáról beszélni és arról nagy vonalakban, hogy mit valósít meg és azután ha ez megvan, akkor a technikai részletek mehetnek már magyarul. Általában szólnak ha úgy gondolják a vizsgáztatók, hogy elég lesz, de ez is vizsgabiztostól függ.
- A PPT és projektmunka tartalmáról részletesebben a Segédletek/Projekthez mappában találjátok, illetve érdemes infojegyzet.hu-n is ránézni.
- Végső soron amikor előadták a vizsgázók a projekt bemutatását, akkor fejenként 2-3 kérdést tesznek fel a projekttel kapcsolatban. A kérdések jellege is függ a vizsgáztató kedvétől/hozzáállásától, de jogilag felhasználói szinten kérdeznek bele.
- - Például: A bankkártya adatot a táblában biztonságosan van-e az adat tárolva és hogyan? Miért van szükség erre a funkcióra? Milyen bővíthetőségi lehetőségei vannak a projektnek? Hogyan oldanád meg máshogyan ezt a problémát?
 

# Megjegyzések:
- A vizsgázónak legalább 40%-kot kell teljesíteni mind a három részből, másképpen elégtelen.
- Ha a vizsgáző megbukik a három vizsgarész valamelyikéből, akkor októberben a javítóvizsgán elegendő az adott vizsgarészt megismételni, amin megbukott a diák.
- Internetes forrásokat, dokumentációkat és fórumokat biztosítani kell valamilyen formában korlátozottan a vizsgázó számára.

# Írásbeli vizsgarészek leírása

- Frontend: A feladatok azok jelenleg 10. és 11. osztályban szerzett gyakorlati anyagok, frisset nem tudtam biztosítani feltöltésre, de általában a képzésnek ezen része a legkülönbözőbb az intézményeknél. Ideális esetben a képzés során a tanulók megismerkednek legalább egy frontend keretrendszerrel. Ez jellemzően Vue, React, Angular szokott lenni, mivel ezek a legpiacképesebbek jelenleg. 
A ***vizsga frontend feladat része így intézménytől függően eltérő lehet***, de azt is figyelembe kell venni, hogy jelenleg (2025-2026 tanév) ***a tanárok állítják össze a feladatsorokat***, így nem feltétlen kell meglepetésre számítani. A mi esetünkben vanilla JS volt chart.js könyvtárral kellett algoritmizálni, de ***általában inkább komponens alapú és kliensoldai fejlesztésre kell számítani*** (Például, hogy egy megadott api útvonalra tudjunk elérési útvonalat megadni.)
- Backend: A vizsgarész teljes mértékben ***REST API*** írásra szakosodik, ezt a hivatalos követelmények is előírják. Általában a fő cél, hogy API endpointokat írjunk, ami képes JSON file-ból küldeni és fogadni requesteket. ***GET, POST, DELETE, PUT*** method használatával kell tudni ***adatbázisba*** írni vagy lekérdezni adatot. Az egyszerű SQL lekérdezéseket és műveleteket kell hozzá ismerni, ami nem bonyolult, viszont egyeseknél okozhat nehézséget ha összetettebb JOIN lekérdezést is kell írni GET-hez (pl.: Ha a feladat megadja, hogy egy terméket kell lekérdezni ÉS a hozzá tartozó kategóriát is, ami esetleg másik táblában van). PHP, Node.js, ASP.NET szokott a legnépszerűbb választás lenni.
- Reszponzív weboldal készítése: Itt ismerni kell a bootstrap osztályokat, grid systemet és media query használatát, header, footer, table, section osztályok szoktak legtöbbször kérni.
- Asztali alkalmazás fejlesztése (CLI): Ezek típusfeladatokból állnak, nagyon kevés esetben nem hasonló a mintafeladat. A tanulónak képesnek kell lennie: Osztályokat használni és konstruktorral objektumot létrehozni ***beolvasott csv/txt file-ból***, programozási tételeket alkalmazni és algoritmizálni műveleteket az objektumokkal: átlag, min, max, keresés user inputra, file írása, összetett adatszerkezetekbe feltölteni és foreach ciklussal végig futtatni, tehát Dictionary (kulcs-érték) vagy List (dinamikus tömb), esetleg hibajavítás és tesztelés (például: Hibásan kapja meg a vizsgázó a csv file-t). ***Tanterv szerint két nyelv közül oldható meg a vizsga: Java vagy C# .NET***
- Asztali alkalmazás fejlesztése (GUI): Java esetében JavaFX, C# .NET-nél pedig Windows Forms vagy WPF-ben történik a vizsga. Ez is eltérő szokott lenni, de nagyságrendileg képesnek kell lennie a vizsgázónak ListView vagy DataGrid-be beolvasni adatokat és azokat szűrni valamilyen módon, mondjuk Text input mezővel keresni tartalomra, legördülő menüvel kategorizálni. Ha a B feladatrészt kapja a vizsgázó, akkor előfordul, hogy adatbázisba is kell egyszerű CRUD műveleteket (Create, Read, Update, Delet) elvégezni, ezt mi specifikusan MySQL .NET extensionnal csináltuk.

# Az anyagok.
- Hiányosak a feladatok, de tartalmaznak szinte mindent, ami előfordult a ***vizsgámon***, amiket megosztottam és feltöltöttem azok tájékoztató jellegűek, a vizsga menete pedig saját tapasztalatról való beszámolás, nem biztos, hogy mindenhol ugyan ez lesz, de jó iránymutatásnak.
- A gyakorló feladatok vagy régebbről vannak, vagy kevés van. Igyekszem frissíteni őket, csak nem sok időm van mostanában, hogy előkeressek mindent, de igyekszem mindig a repo-t frissen tartani, hogy aktuális legyen.

