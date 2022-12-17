Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int l = Convert.ToString(n).Length;
int a = 0;
int b = 0;
for (int i = 0; i < l; i++)
{
    a = n - n % 10;
    b = b + (n - a);
    n = n / 10;
}
Console.WriteLine(b);