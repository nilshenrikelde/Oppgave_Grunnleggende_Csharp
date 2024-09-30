/*

dotnet --help = gir oss masse nyttige kommandoer og informasjon om selve .NET Framework CLIet

dotnet new list = skriver ut en liste av argumenter vi kan gi til .NET Framework CLIet

dotnet new console --use-program-main = lager et CLI prosjekt, det er dette dere hovedsakelig vil jobbe med i mine timer.

*/

namespace Oppgave_Grunnleggende_Csharp;

class Program
{
    static void Main(string[] args)
    {
       // 1. Lag en variabel av datatypen integer og tildel den et vilkårlig heltall
        int mittHeltall = 6;
        Console.WriteLine (mittHeltall);
       
       // 2. Lag en variabel av datatypen string og tilden en vilkårlig tekst
        string streng = "Dette er en streng!";
        Console.WriteLine (streng);
        
       //3. Lag en variabel av datatypen double og tilden et vilkårlig tall, både desimal og heltall er gyldig med denne typen
        double mittDesimaltall = 66.6;
        Console.WriteLine (mittHeltall + mittDesimaltall);

        //4. Lag en variabel av datatypen char og tildel den en vilkårlig karakter(bokstav)
        char minKarakter = 'a';
        Console.WriteLine (minKarakter);

        //5. Lag et Array av datatypen integer og skriv ut verdiene med en vanlig for-løkke
        
        //6. Lag et Array av datatypen string og skriv ut verdiene med en foreach-løkke
      
        //7. Lag en List av datatypen string og tildel verdier ved hjelp av List sin innebygde metode "Add()"

        //8. Legg til flere strings i listen deres

        //9. Skriv ut verdiene i listen ved hjelp av en foreach-løkke

       
    }
}

