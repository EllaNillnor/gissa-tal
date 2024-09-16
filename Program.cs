// See https://aka.ms/new-console-template for more information

Random rnd = new Random();
int tal= rnd.Next(1,101);

Console.Write("Gissa vilket heltal mellan 1 & 100 som datorn valt: ");
    string svar = Console.ReadLine(); 
    int gissning = int.Parse(svar);

while(gissning != tal)
{

        if(gissning <= tal ){
            Console.WriteLine("gissningen är för låg");
            Console.Write("gör en ny gissning: ");
            string svar1 = Console.ReadLine();
            gissning = int.Parse(svar1);
        }
        else{
            Console.WriteLine("gissningne är för hög");
            Console.Write("gör en ny gissning: ");
            string svar2 = Console.ReadLine();
            gissning = int.Parse(svar2);
        }
}
Console.Write("Du gissade rätt! talet var ");
Console.Write(tal);
Console.WriteLine("antal gissningar ");
Console.WriteLine();
