/*

dotnet --help = gir oss masse nyttige kommandoer og informasjon om selve .NET Framework CLIet

dotnet new list = skriver ut en liste av argumenter vi kan gi til .NET Framework CLIet

dotnet new console --use-program-main = lager et CLI prosjekt, det er dette dere hovedsakelig vil jobbe med i mine timer.

*/

using System.Collections.ObjectModel;
using System.Runtime.InteropServices.Marshalling;

namespace Oppgave_Grunnleggende_Csharp;

class Program
{
    static void Main(string[] args)
    {
       // 1. Lag en variabel av datatypen integer og tildel den et vilkårlig heltall
        int mittHeltall = 6;
        Console.WriteLine ("Mitt tall er: " + mittHeltall);
       
       // 2. Lag en variabel av datatypen string og tilden en vilkårlig tekst
        string streng = "Dette er en streng!";
        Console.WriteLine (streng);
        
       //3. Lag en variabel av datatypen double og tilden et vilkårlig tall, både desimal og heltall er gyldig med denne typen
        double mittDesimaltall = 66.6;
        Console.WriteLine ("Mitt desimaltall er: " + mittDesimaltall);

        //4. Lag en variabel av datatypen char og tildel den en vilkårlig karakter(bokstav)
        char minKarakter = 'a';
        Console.WriteLine ("Min bokstav er: " + minKarakter);

        //5. Lag et Array av datatypen integer og skriv ut verdiene med en vanlig for-løkke

        Console.WriteLine ("Mitt tall-array:");

        int [] arrayHel = {1,2,3,4,5};
        for (int i = 0; i < arrayHel.Length; i++)
        
        Console.WriteLine (arrayHel[i]);
        
        //6. Lag et Array av datatypen string og skriv ut verdiene med en foreach-løkke
      
        Console.WriteLine ("Mitt string-array:");

        string[] farger = { "red", "yellow", "pink", "green", "orange", "purple", "blue" };
        foreach (string i in farger)
        {
        Console.WriteLine(i);
        }

        //7. Lag en List av datatypen string og tildel verdier ved hjelp av List sin innebygde metode "Add()"

        List<string> fruits = new List<string>();

        fruits.Add("Apple");

        //8. Legg til flere strings i listen deres

        fruits.Add("Banana");
        fruits.Add("Orange");
        fruits.Add("Kiwi");
        fruits.Add("Strawberry");

        //9. Skriv ut verdiene i listen ved hjelp av en foreach-løkke

        foreach (string f in fruits)
        {
        Console.WriteLine(f);
       
        }
    }
}

