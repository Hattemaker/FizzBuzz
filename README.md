## FizzBuzzJazzFuzz
Dette er et prosjekt i forbindelse med invervjuprosess hos Epinova.

### Prosjektet inkluderer:
- FizzBuzzProgram
- FizzBuzzTest

Dette er det første prosjektet jeg har skrevet i  C#, har hovedsaklig holdt på med Java, Phython, PHP, samt litt GoLang tidligere.

### Struktur
- FizzBuzzProgram
  - mappen inneholder en bedre konfigurering av FizzBuzz, hvor FizzBuzzGame tar i bruk interface IFizzBuzzGame og et sett med regler. For hver kjøring av programmet gjennom RunGame(list) må en legge til regler man selv ønsker (en string og en multiplier Int) gjennom metoden Rules.Add(). På denne måten kan programmet kjøres med ønskede parametre uten å endre noe kode.
  - Etter en kjøring kan man også velge å kjøre metoden Rules.Clear() for å fjerne de nåværende parametre.
  - Dersom en vil kjøre listen (1-100) baklengs har man mulighet til å gjøre dette ved å bytte ut parameter "list" med "reversedList".

### Fjernet
I denne iterasjonen av oppgaven har jeg fjernet tidligere iterasjoner av oppgaven, da disse ikke lenger var ønsket å ha med, samt fjernet unødvendige filer. Har også lagt til .gitignore med parametre jeg mener var passende, og ser selv nå ikke at noen uønskede mapper eller filer blir hengende igjen i prosjektet.

Prosjektet er delt med [Kristian Borg](https://github.com/BorgKristian) og [Thomas Leela](https://github.com/tholee).
