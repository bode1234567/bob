// See https://aka.ms/new-console-template for more information
Console.Write("n=");
int n = int.Parse(Console.ReadLine());
Console.Write("m=");
string m = Console.ReadLine();
for (int i = 1; i <= n; i++)
{
    Console.WriteLine(m);
}

for (int x = 10; x <= 99; x++)
{
    if (x % 11 == 0)
    {
        Console.WriteLine(x);
    }
}

int y = 0;
for (int x = 10; x <= 99; x++)
{
    if (x % 16 == 0)
    {
        Console.WriteLine(x); y++;
    }
}
Console.WriteLine($"кол-во = {y}");

int k = 0; int s = 0;
for (int x = 10; x <= 99; x++)
{
    if (x % 25 == 0)
    {
        Console.WriteLine(x);
        k++;
        s += x;

    }
}
Console.WriteLine($"k={k}");
Console.WriteLine($"s={s}");

for (int x = 22; x <= 99; x++)
{
    Console.WriteLine(x);
}

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("привет");
}

int con = 0;
for (int x = 10; x <= 99; x++)
{
    if (x % 2 == 0)
    {
        Console.WriteLine(x); con++;

    }
}
Console.Read();



for (int f = 22; f <= 99; f++)
{
    if (f % 11 == 0)
    {
        Console.WriteLine(f);
    }
} 
        
  