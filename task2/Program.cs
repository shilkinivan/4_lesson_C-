Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = n;
int b = 0;
while (a > 0)
{
    int c = a % 10;
    if (c == 0 || n % c == 0)
    {
        b += c;
    }
    a = a / 10;
}
Console.Write(b);