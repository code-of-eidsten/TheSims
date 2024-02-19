/*
 3 Modus: Family, Build & Play  => en klasse til hver
Skal opprette familiemedlemmer i familiemodus => Voksen eller barn. Skal ha friendship status med andre mennesker
Etter familymodus går man over i buildmode => ferdigdefinerte rom. Kan legge til så mange rom man vil av hver type. Huset skal ha flere etasjer, som kan ha rom
 => en klasse for hus, liste over etasjer, etasjer har liste med rom
Rommene kan dekoreres med innhold som bord, kjøleskap, vask etc
Gjenstandene skal ha tilknyttede handlinger ex Kjøleskap - Hente mat  etc
Ferdig med buildmode -> over i Playmode.
Playmode: Bevege seg rundt i rommene og se hva som finnes av gjenstander og evt andre personer og interacte med dem/det.
 
 */
using TheSims;

Console.WriteLine("Welcome to ConsoleSims! Lets start by Creating a sim!");
var createMode = new FamilyMode();
createMode.CreatePerson();
