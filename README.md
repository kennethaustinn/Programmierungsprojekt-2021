# Programmierprojekt: Digitalisierung in der Pflege

* Teammitglieder:
	1. Ala Al-Khazzan
	2. Kenneth Austin
	3. Paul Schult (leider Gruppe verlassen)
* Team: 2
* Semester: SoSe 21

Mit Hilfe dieses Projekts soll der Beruf der ambulanten Pflege durch Nutzung digitaler Hilfsmittel attraktiver gestaltet werden. 
Die zu entwickelnde Anwendung wird die bisher handschriftliche Patientendokumentation digitalisieren und organisieren. 
Dadurch werden die Pflegekräfte zeitlich entlastet und die Daten (zukünftig) für die Mitarbeiter überall verfügbar sein.
Durch Texterkennung, mittels Ocr von IronOcr, können handschriftliche Dokumente eingelesen und abgespeichert werden. 


## Installationshinweise

Die Installation sollte über das Klonen des ganzen Projekts erfolgen.
Dabei sollten keine Probleme auftauchen. Falls doch dann einmal im VS Installer ein neues Workload hinzufügen:
VS Installer -> Ändern -> "Datenspeicherung und -verarbeitung" installieren. Dieses Tool wird für das arbeiten mit der Datenbank gebraucht.

Falls die Installation über das downloaden der Zip Datei erfolgt, dann sind zwei Schritte zu beachten.
1. Nach dem downloaden rechtsklick auf den Zip Ordner und auf Eigenschaften klicken.
2. Dann die Sicherheit, ganz unten, beim Häcken Zulassen anklicken.

Somit wird sichergestellt, dass die Forms laden. Da sonst alle .resx Datei aus Sicherheitsgründen von VS ignoriert werden,
weil die aus dem Internet(gitLab) runtergeladen sind. Auch hier den Fehler für den Workload beachten (s.oben).

## Verwendung der Software
Wie verwendet man diese Software? Welches Programm muss man starten?
Um die Software zu benutzen muss man die .sln Datei unter /programm/CareSolution/CareSolution.sln erstmal öffnen.
Nach Starten der Software, kommt man im Login bereich. Da einmal "ala" als Username und "123" als Passwort eingeben.
Zum Testen der Software empfehlt es sich:
- Einen Pateinten in die Datenabnk einfügen
- Patient auswählen, indem seine zugehörigen Stammdaten angezeigt werden. (Dies gilt nur für die PersonID 1,7,8,10)
- Das einlesen der Biografie und Pflegeberichts aus den Vorhandenen Vorlagen
- Nach Konvertierung der Biografie Datei in eine Pdf, lässt sich in der neuen Pdf nach Wörtern suchen.

Falls geguckt werden soll, ob die neuen Daten (neuer Patient, Bio und Pflegebericht) oder die alten in der Datenbank eingefügt wurden sind, muss folgendens gemacht werden:
1. Einmal den SQL-Server-Explorer in der Ansicht öffnen (entweder unten oder Oben über den Reiter Ansicht öffen)
2. Dann die Datenbank mit den Tabellen (unter /programm/CareSolution/CareSolution/bin/Debug/AmbulantCare.mdf) öffnen und gucken ob die neuen Daten hinzugefügt wurden (aktulisieren).
3. Falls nochmal das Programm gestartet werden soll oder der SQL-Explorer parallel offen ist, dann bitte die Ansicht des SQL-Explorer verlassen. Da sonst SQL und VS parallel arbeiten würden. ->Fehlermedlung.

## Verwendung des Auswertungsprogramm
Um das Auswertungsprogrammzu benutzen muss man die .sln Datei unter /programm/DummyFoOCR/DummyForOCR.sln erstmal öffnen.
Nach Starten des Auswertungsprogramm erscheint die Konsolenanwendnung.
Zum Testen des Auswertungsprogramm empfehlt es sich:
- Eine Datei einlesen  -> (Eingabe 0)
- BioTest0.png bis BioTest9.png wählen -> (Eingabe 0-10), Außer BioTest1--> Ausreisser, welcher zu einer Fehlermeldung führt.
- Konsolenausgabe ansehen -> Auswertung

Die Ergbnisse des Auswertungsprogramm sind in der ReadME Datei unter	/programm	
	       				
## Links, Hinweise etc.

1. Markdown Syntax: https://docs.gitlab.com/ee/user/markdown.html
2. Git fuer Windows: https://git-scm.com/download/win
3. Nutzen Sie zur Organisation von Teamaufgaben das Kanban-Board unter Issues/Boards im gitlab!