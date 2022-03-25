// See https://aka.ms/new-console-template for more information
int n, i;
Console.WriteLine("Digite el valor de n: ");
n = Convert.ToInt32(Console.ReadLine());
for (i = 0; i<=10; i++)
{
    Console.WriteLine("{0} x {1} = {2}", n,i,(n*i));
}
Console.ReadKey(true);