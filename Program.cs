// See https://aka.ms/new-console-template for more information

Random rnd = new Random();
int tal= rnd.Next(1,101);

int count = 0;

Console.Write("Gissa vilket heltal mellan 1 & 100 som datorn valt: ");
    int gissning = int.Parse(Console.ReadLine());

while(gissning != tal)
{

        if(gissning <= tal ){
            Console.WriteLine("gissningen är för låg");
            Console.Write("gör en ny gissning: ");
            gissning = int.Parse(Console.ReadLine());
            count++;
        }
        else{
            Console.WriteLine("gissningne är för hög");
            Console.Write("gör en ny gissning: ");
            gissning = int.Parse(Console.ReadLine());
            count++;
        }
}
Console.WriteLine("Du gissade rätt! talet var "+ tal );
Console.WriteLine("antal gissningar: " + count );

