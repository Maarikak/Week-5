
//////////////0 (or below) - Freezing
//////////////from 0 to 5 - cold
//////////////from 5 to 10 - chilly
//////////////from 10 to 15 - cool
//////////////from 15 to 28 - warm
//////////////above 28 - boiling hot


Console.WriteLine("Enter the current temp:");
int currenttemp = Int32.Parse(Console.ReadLine());

if (currenttemp <= 0)
{
    Console.WriteLine("Freezing");
}
else if (currenttemp > 0 && currenttemp < 5)
{
    Console.WriteLine("Cold");
}
else if (currenttemp >=5 && currenttemp < 10)
{
    Console.WriteLine("Chilly");
}

else if (currenttemp >=10 && currenttemp < 15)
{
    Console.WriteLine("Cool!");
}
else if (currenttemp >=15 && currenttemp < 28)
{
    Console.WriteLine("Warm!");
}
else
{
    Console.WriteLine("Boiling hot!");
}