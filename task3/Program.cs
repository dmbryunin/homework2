Console.Clear();

nat1:

Console.WriteLine("vvedite chislo ot 1 do 7");

int a = Convert.ToInt32(Console.ReadLine());

while (a<1 || a>7)
    goto nat1;
if (a==6 || a==7)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");