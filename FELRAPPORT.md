### Fel: Possble null reference
Återskapa:
1. Starta programmet
2. Följande visas direkt: warning CS8604: Possible null reference argument for parameter 'a' in 'int IntConverter(string a)'.
3. Notera: Detta händer inte vid varje run utan vid första körning och efter programändring, för att återskapa du lägga in/ändra kommentar i program.cs

#### Åtgärd
La till en nullforgiving operator på Console.ReadLine (rad 21);

### Fel: Input av icke-heltal ger programkörningsfel
1. Starta programmet
2. Direkt visas en inmatning med "Skriv in ett heltal"
3. Skriv ett icke-heltal (sträng eller decimaltal)
4. En programkörning vsias: The input string '...' was not in a correct format. Från rad 13 i program.cs
5. Efter läsning av kod i program.cs. Detta verkar bero på bristfällig kontroll i funkionen IntConverter (som börjar på rad 11)

### Fel: Felaktig addition
1. Starta programmet.
2. "Adding 1.0 and 3.5 = −2,5" visas direkt. Detta är inte korrekt addition.
3. Efter läsning av kod i program.cs verkar detta bero på fel i funktionen Add (som börjar på rad 1).

### Fel: Felaktig subraktion
1. Starta programmet.
2. "Substracting 1.0 with 1.5 = 2,5" visas direkt. Detta är inte korrekt subtraktion.
3. Efter läsning av kod i program.cs verkar detta bero på fel i funktionen Subtract (som börjar på rad 6).