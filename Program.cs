
using System;

Console.WriteLine("Wilkommen zum Stronghold Calculator von Kishud7");
Console.WriteLine("------------------------------------------");

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
    Console.WriteLine("Die Winkel sind zu ähnlich.");
    Console.WriteLine("Stronghold konnte nicht berechnet werden.");
}
else
{
    // Schnittpunkt berechnen
    double t = ((x2 - x1) * dz2 - (z2 - z1) * dx2) / nenner;
    double u = ((x2 - x1) * dz1 - (z2 - z1) * dx1) / nenner;

    // Stronghold Koordinaten
    double strongholdX = x1 + t * dx1;
    double strongholdZ = z1 + t * dz1;

 