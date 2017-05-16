# Simple Quiz App

Uitbreidingen:

- Refactor de applicatie zodat de `Main`-method wat wordt opgekuist.
  Maak hiervoor een class `VragenLijst` met de methods `VoegVraagToe(...)` en `PrintRapport()`. Gebruik een method `Start` om de vragenlijst te starten.
  (Later kunnen we hiermee verschillende vragenlijsten maken waaruit de speler dan eventueel in het begin uit kan kiezen.)
- Maak een class `TijdVraag` die overerft van `Vraag` en bijhoudt hoe lang het duurt eer er een antwoord werd gegeven.
  (HINT: Gebruik voor en na de invoer van de gebruiker de `DateTime.Now`-property en bereken het verschil (van type `TimeSpan`).)
  Hoe structureren we de verschillende classes om deze tijden op het einde weer te geven en toch overerving (polymorfie) te laten werken?
  (HINT: Misschien is het beter om de rapportering van de vraag aan `Vraag` zelf over te laten? Bij het rapporteren moeten we nu immers ook de tijd weergeven!)
- Maak een class `MeerkeuzeVraag` die overerft van `Vraag`. Optioneel moeten de mogelijke antwoorden willekeurig door elkaar gegooid worden.
  De opsteller v.d. quiz kan dan (in de code) met b.v. een property `WillekeurigeVolgorde` hiervoor kiezen. (Van welk type moet deze property zijn?)
- Geef de class `VragenLijst` een method (of eventueel constructor?) waar je het **pad van een file** kan aan geven.
  In deze file kunnen dan verschillende vragen en antwoorden staan.
  Het zou ervoor zorgen dat het programma veel bruikbaarder wordt omdat we dan immers niet meer met *hard-coded* vragen moeten werken!
  Bedenk zelf een gepast formaat voor dergelijk tekst-bestand, b.v. 1 regel voor de vraag en 1 regel voor het antwoord.
- Hoe zou je het aanpakken om de resultaten op schijf op te slaan zodat b.v. een spel kan gestopt en later verder gezet kan worden?



