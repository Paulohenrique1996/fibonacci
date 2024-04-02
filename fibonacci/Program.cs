// See https://aka.ms/new-console-template for more information
int fibo, a = 0, b = 1, c = 0;
Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("digite o limitaodor: ");
var num = int.Parse(Console.ReadLine());
for(fibo = 1; fibo <= num; fibo ++)
{
    c = a + b;
    Console.Write(c + " ");
    b = a;
    a = c;


}
Console.ReadKey();