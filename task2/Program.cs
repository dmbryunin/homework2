Console.Clear();

Console.WriteLine("vvedite chislo");

int n=Convert.ToInt32(Console.ReadLine());

if (Math.Abs(n)<100)
    Console.WriteLine("net tretey cifri");
else{
    while (n>1000)
        n=n/10;
    Console.WriteLine(n%10);
}