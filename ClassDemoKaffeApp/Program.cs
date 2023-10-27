// See https://aka.ms/new-console-template for more information
using ClassDemoKaffeApp;

Console.WriteLine("Hello, World!");


Kaffe kaffe1 = new Kaffe("Kenya", "Arabica", 55, "Mellem");
Console.WriteLine(kaffe1);

Kunde kunde1 = new Kunde(21, "peter", "33445566");
Console.WriteLine(kunde1);

Køb køb1 = new Køb(kaffe1, kunde1);
Console.WriteLine(køb1);


kunde1.Navn = "Jakob";
Console.WriteLine(kunde1);
Console.WriteLine(køb1);

køb1.Kunde.Navn = "Per";
Console.WriteLine(kunde1);


/*
 * BRUG AF KAFFE LISTE
 */

KaffeListe kaffeListe = new KaffeListe();
kaffeListe.Tilføj(kaffe1);

Kaffe kaffe2 = new Kaffe("Peru", "robusta", 33, "mørk");
kaffeListe.Tilføj(kaffe2);

Kaffe kaffe3 = new Kaffe("Kenya", "robusta", 33, "mellem");
kaffeListe.Tilføj(kaffe3);

List<Kaffe> kaffer = kaffeListe.HentAlleKaffer();

for (int i = 0; i < kaffer.Count; i++)
{
    Console.WriteLine(kaffer[i]);
}



Console.WriteLine("Fra Kenya");

List<Kaffe> kaffeFraDanmark = kaffeListe.HentFraLand("Kenya");

//for (int i = 0; i < kaffeFraDanmark.Count; i++)
//{
//    Console.WriteLine(kaffeFraDanmark[i]);
//}

foreach (Kaffe kaffe in kaffeFraDanmark)
{
    Console.WriteLine(kaffe);
}



/*
 * BRUG AF KUNDE KATALOG
 */

KundeKatalog katalog = new KundeKatalog();

katalog.Tilføj(kunde1);
katalog.Tilføj(new Kunde(22, "Jakob", "44556677"));

Console.WriteLine(katalog);


try
{
    Kunde kunde22 = katalog.HentKunde(22);
    Console.WriteLine(kunde22);
}
catch (KeyNotFoundException knfe)
{
    Console.WriteLine("FEJL: " + knfe.Message);
}

try
{ // her kan der måske ske en exception
    Console.WriteLine(katalog.HentKunde(222));

}
catch(KeyNotFoundException knfe)
{
    Console.WriteLine("FEJL: " + knfe.Message);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine(katalog.HentKundeUdFraTlf("33445566"));




try
{
    kaffe1.Pris = 45;
    kaffe1.Pris = -34;
}
catch(ArgumentException ae)
{
    Console.WriteLine( ae.Message);
}

try
{
    kaffe2.Pris = -1;
}
catch (ArgumentException ae)
{
    Console.WriteLine(ae.Message);
}

Console.WriteLine(  "SLUT");