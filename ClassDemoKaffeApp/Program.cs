// See https://aka.ms/new-console-template for more information
using ClassDemoKaffeApp;

Console.WriteLine("Hello, World!");


Kaffe kaffe1 = new Kaffe("Kenya", "Arabica", 55, "Mellem");
Console.WriteLine(kaffe1);

Kunde kunde1 = new Kunde("peter", "33445566");
Console.WriteLine(kunde1);

Køb køb1 = new Køb(kaffe1, kunde1);
Console.WriteLine(køb1);


kunde1.Navn = "Jakob";
Console.WriteLine(kunde1);
Console.WriteLine(køb1);

køb1.Kunde.Navn = "Per";
Console.WriteLine(kunde1);