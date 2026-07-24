# Útmutató a hozzájáruláshoz (Contributing)

Először is, köszönöm, hogy érdeklődsz a **Szoftverfejlesztő szakmai vizsga feladatok** projekt iránt! 

A projekt célja egy minél átfogóbb, hasznosabb és naprakészebb gyűjtemény létrehozása a szoftverfejlesztő vizsgákra készülők számára. **Ha segíteni akarod a tudásbázis bővítését, akkor kérlek, segíts be saját anyagokkal!** Minden kidolgozott tételt, gyakorló feladatot, hibajavítást vagy alternatív kódmegoldást szívesen fogadok.

## Mivel tudsz hozzájárulni?

*   **Saját anyagok és feladatok feltöltése:** Ha vannak korábbi vizsgasorokhoz tartozó feladataid, kidolgozott tételeid vagy jegyzeteid.
*   **Meglévő feladatok javítása:** Ha elírást, hibát vagy nem működő kódot találsz valamelyik meglévő anyagban.
*   **Alternatív megoldások:** Ha egy feladatra van egy szebb, hatékonyabb vagy más nyelven írt megoldásod.

## A hozzájárulás menete (Pull Request)

Ha anyagot szeretnél beküldeni, kérlek, kövesd az alábbi lépéseket:

1. **Forkold** ezt a repozitóriumot a jobb felső sarokban található *Fork* gombbal.
2. **Klónozd** a saját forkolt repódat a gépedre:
   ```bash
   git clone https://github.com/A_TE_FELHASZNALONEVED/Szoftverfejleszto-szakmai-vizsga-feladatok.git
   ```
3. Készíts egy **új branch-et** a módosításaidnak:
   ```bash
   git checkout -b uj-vizsga-anyag
   ```
4. **Tedd hozzá a saját anyagaidat**, végezd el a módosításokat. Kérlek, figyelj arra, hogy a mappaszerkezetbe logikusan illeszkedjenek az új fájlok.
5. **Commitold** a változtatásokat egy beszédes üzenettel:
   ```bash
   git commit -m "Új 2023-as vizsgafeladat megoldása hozzáadva"
   ```
6. **Pushold** fel a branch-et a GitHubra:
   ```bash
   git push origin uj-vizsga-anyag
   ```
7. A GitHub felületén nyiss egy **Pull Requestet** (PR-t) az eredeti repozitórium felé. 

## Irányelvek a beküldött anyagokhoz

*   **Olvashatóság:** A kódjaid legyenek átláthatóak, lehetőség szerint kommentezettek, hogy a tanulni vágyók könnyen megérthessék őket.
*   **Fájlnevek:** Használj egyértelmű, ékezet nélküli fájlneveket (pl. `feladat_01_megoldas.py`).
*   **Szerzői jog:** Kérlek, csak olyan anyagokat (pl. feladatlapokat) ossz meg, amelyek publikusak vagy amelyek megosztása nem sért szerzői jogokat.

Köszönöm a segítségedet, építsük együtt tovább a tudásbázist!
