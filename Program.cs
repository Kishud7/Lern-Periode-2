Console.WriteLine("------------------------------------------------");
Console.WriteLine("Willkommen zum Stronghold Calculator von Kishud7");
Console.WriteLine("------------------------------------------------");

Console.WriteLine("");
Console.WriteLine("Anleitung:");
Console.WriteLine("Bitte wirf mindestens 2 Enderaugen an verschiedenen Orten.");
Console.WriteLine("Notiere die X- und Z-Koordinaten und den Blickwinkel (FN + F3).");
Console.WriteLine("Gib danach die Werte hier ein.");
Console.WriteLine("Benutze den Winkel aus der F3-Anzeige (Yaw).");
Console.WriteLine("");

// Erste Position
Console.WriteLine("Erste Position");

Console.Write("X: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Z: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Winkel: ");
double winkel1 = Convert.ToDouble(Console.ReadLine());

// Zweite Position
Console.WriteLine("");
Console.WriteLine("Zweite Position");

Console.Write("X: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Z: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Winkel: ");
double winkel2 = Convert.ToDouble(Console.ReadLine());

// Winkel umrechnen
double a = winkel1 * Math.PI / 180;
double b = winkel2 * Math.PI / 180;

// Blickrichtungen berechnen
double dx1 = -Math.Sin(a);
double dz1 = Math.Cos(a);

double dx2 = -Math.Sin(b);
double dz2 = Math.Cos(b);

// Berechnung vorbereiten
double nenner = dx1 * dz2 - dz1 * dx2;

// Überprüfen, ob die Berechnung möglich ist
if (Math.Abs(nenner) < 0.000001)
{
    Console.WriteLine("");
    Console.WriteLine("Die Winkel sind zu ähnlich.");
    Console.WriteLine("Stronghold konnte nicht berechnet werden.");
    Console.WriteLine("Bitte versuche es mit anderen Positionen.");
}
else
{
    // Schnittpunkt berechnen
    double t = ((x2 - x1) * dz2 - (z2 - z1) * dx2) / nenner;
    double u = ((x2 - x1) * dz1 - (z2 - z1) * dx1) / nenner;

    // Stronghold Koordinaten
    double strongholdX = x1 + t * dx1;
    double strongholdZ = z1 + t * dz1;

    // Überprüfen, ob das Stronghold vor uns liegt
    if (t < 0 || u < 0)
    {
        Console.WriteLine("");
        Console.WriteLine("Fehler bei der Berechnung!");
        Console.WriteLine("Die Blickrichtungen zeigen nicht zum gleichen Ziel.");
        Console.WriteLine("Bitte überprüfe deine Eingaben.");
    }
    else
    {
        // Ergebnis anzeigen
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("           STRONGHOLD GEFUNDEN!");
        Console.WriteLine("------------------------------------------------");

        Console.WriteLine("");
        Console.WriteLine("Stronghold X: " + Math.Round(strongholdX));
        Console.WriteLine("Stronghold Z: " + Math.Round(strongholdZ));

        // Entfernung von der zweiten Position
        double unterschiedX = strongholdX - x2;
        double unterschiedZ = strongholdZ - z2;

        double entfernung = Math.Sqrt(
            unterschiedX * unterschiedX +
            unterschiedZ * unterschiedZ
        );

        Console.WriteLine("");
        Console.WriteLine("Entfernung von der zweiten Position:");
        Console.WriteLine(Math.Round(entfernung) + " Blöcke");

        Console.WriteLine("");
        Console.WriteLine("Achtung: Die Koordinaten sind nur ungefähr.");
        Console.WriteLine("Viel Erfolg beim Finden des Strongholds!");
    }
}

Console.WriteLine("");
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Drücke Enter zum Beenden.");
Console.WriteLine("------------------------------------------------");
Console.ReadLine();


