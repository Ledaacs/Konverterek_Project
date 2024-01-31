
# Konverterek

### Ledacs-Kiss Bence 

Leressünk a <font color="red" style="font-weight:900">c#</font>-hoz megfelelő konvertáló könyvtárakat, amik segítségével különböző fájl formátumok egymásba konvertálhatók.

A feladat
Írunk egy programot, ami különböző fájl formátumot megadott formátumba konvertálja.

Példák (lehet több is):

csv <-> json

csv <-> excel

csv <-> word táblázat

html <-> pdf

html <-> Markdown

html <-> Word

pdf <-> Word

DLL konverter motor
A projekt célszerűen egy Statikus osztály legyen DLL-ben, hogy akármilyen projekthez felhasználható legyen. A DLL a metódusain keresztül működjön.
 Példa:

csv -> json: CsvToJson(csvForrásfájl, jsonCélfájl)

A konverter működése

A konverter a megírt DLL motort használja a konvertálásra. Működése, ha a program neve: convert.exe és például egy csv fájlból akarunk jsont készíteni, akkor parancssorból így hívjuk meg:

convert valami.csv valami.json

A program ilyenkor a két paraméterben megadott fájl kiterjesztéséből találja ki, hogy miből mit kell csinálnia, és ehhez a megfelelő DLL függvényt kell meghívnia a megfelelő paraméterekkel. Természetesen forrás fájl ellenőrzést is végez, valamint ha ilyen konvertere nincs, üzen, hogy nem tudja megcsinálni.

A konverter help-je
Legyen egy belső leírása a programnak, hogy kell használni, és ez lekérdezhető legyen. MOndjuk úgy, hogy ha a programot paraméter nélkül indítjuk, ez a help litázódjon ki a képernyőre.

Általános megkötések a DLL fájllal kapcsolatban.
Elnevezés rendszer
Gondoljon arra, hogy DLL-jét mások is használni fogják, így

Minden elnevezése angolul legyen.
Az elnevezések fejezzék ki azt, amit csinálnak.
Használja az úgynevezett puputeve (Az egész egybeírva, résszavak nagybetűvel) elnevezés típust egységesen.
Következetesen:
Osztálynév: nagybetűvel kezdődik
Metódusnév: Nagybetűvel kezdődik
változók, gyűjtemények: kisbetűvel kezdődik

<a href="https://github.com/Ledaacs">My Profile</a>