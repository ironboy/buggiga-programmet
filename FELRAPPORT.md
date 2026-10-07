### Fel: Possble null reference
Återskapa:
1. Starta programmet
2. Följande visas direkt: warning CS8604: Possible null reference argument for parameter 'a' in 'int IntConverter(string a)'.
3. Notera: Detta händer inte vid varje run utan vid första körning och efter programändring, för att återskapa du lägga in/ändra kommentar i program.cs

#### Åtgärd
* La till en nullforgiving operator på Console.ReadLine (rad 21)
* Commit hash: 8f592ff55910b44dce3e4a4a44a08fcd98e06215

### Fel: Input av icke-heltal ger programkörningsfel
1. Starta programmet
2. Direkt visas en inmatning med "Skriv in ett heltal"
3. Skriv ett icke-heltal (sträng eller decimaltal)
4. En programkörning vsias: The input string '...' was not in a correct format. Från rad 13 i program.cs
5. Efter läsning av kod i program.cs. Detta verkar bero på bristfällig kontroll i funkionen IntConverter (som börjar på rad 11)

#### Åtgärd
* Bytte int.Parse mot int.TryParse i IntConverter.
* La till en while-loop som ber användaren göra om till hen skriver ett heltal
* Commit hash: d926f53ab51aae42207510f64ed5de590bbb221c

### Fel: Felaktig addition
1. Starta programmet.
2. "Adding 1.0 and 3.5 = −2,5" visas direkt. Detta är inte korrekt addition.
3. Efter läsning av kod i program.cs verkar detta bero på fel i funktionen Add (som börjar på rad 1).

#### Åtgärd
* Ändrade operator från - till + på rad 3 (inne i Add-funktionen).
* Commit hash: 154ef18d31403f2916ef4210191192e89d127763

### Fel: Felaktig subraktion
1. Starta programmet.
2. "Substracting 1.0 with 1.5 = 2,5" visas direkt. Detta är inte korrekt subtraktion.
3. Efter läsning av kod i program.cs verkar detta bero på fel i funktionen Subtract (som börjar på rad 6).

#### Åtgärd
* Ändrade operator från + till - på rad 8 (inne i Substract-funktionen).
* Commit hash: 28881dee819fd63fc96713dbc3e3eb47c8a6b13b

### UX-fel: Inget avstånde eter "Skriv in helal"
1. Starta programmet
2. Programmet ber om inmatning. Instruktionen ser lite svårläst ut då inmatning kommer direkt efter ordet "heltal"

#### Förslag till åtgärd
* Förslag lägg till ": " för ökad läsbarhet

### UX-fel
1. Starta programmet.
2. Skriv in ett giltigt heltal när programmet ber om inmatning¨
3. "Talet plus 1 är $..." visas. Dollartecken varför? Kanske en JS-kodare som skriver C-sharp?

#### Förslag till åtgärd
* Ta bort dollartecken