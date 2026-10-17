static void PrintHeader(string title)
{
    Console.WriteLine("🟦🟦🟦🟦🟦🟦🟦🟦🟦🟦");
    Console.WriteLine(title);
    Console.WriteLine("🟦🟦🟦🟦🟦🟦🟦🟦🟦🟦");
}

static int Max(int a, int b)
{
    if (a > b) return a;
    return b;
}

static bool IsEven(int n)
{
    return n % 2 == 0;
}

static double Average(int[] arr)
{
    int sum = 0;
    foreach (int num in arr) sum += num;
    return (double)sum / arr.Length;
}

static int CountGreater(int[] arr, int limit)
{
    int count = 0;
    foreach (int num in arr) if (num > limit) count++;
    return count;
}

static double ToFahrenheit(double celsius)
{
    return (celsius * 9.0 / 5.0) + 32;
}

static long Factorial(int n)
{
    long result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

static bool IsPrime(int n)
{
    if (n < 2) return false;
    for (int i = 2; i * i <= n; i++) if (n % i == 0) return false;
    return true;
}

static int ReadPositive(string message)
{
    int number;
    do
    {
        Console.Write(message);
    } while (!int.TryParse(Console.ReadLine(), out number) || number <= 0);
    return number;
}

static int Sum(int a, int b)
{
    return a + b;
}

static int Gcd(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

static int Lcm(int a, int b)
{
    return a / Gcd(a, b) * b;
}

PrintHeader("вась");
PrintHeader("велосипе");

Console.WriteLine(Max(10, 20));
Console.WriteLine(Max(100, 50));
Console.WriteLine(Max(-5, -10));

Console.WriteLine(IsEven(4));
Console.WriteLine(IsEven(7));
Console.WriteLine(IsEven(0));

int[] numbers = { 120, 45, 300, 80, 15, 210 };
Console.WriteLine($"Среднее: {Average(numbers):0.00}");
Console.WriteLine($"Больше 100: {CountGreater(numbers, 100)}");

Console.WriteLine(ToFahrenheit(0));
Console.WriteLine(ToFahrenheit(100));
Console.WriteLine(ToFahrenheit(37));

Console.WriteLine(Factorial(5));

for (int i = 2; i <= 50; i++)
{
    if (IsPrime(i))
    {
        Console.Write($"{i} ");
    }
}
Console.WriteLine();

int first = ReadPositive("Введите первое число: ");
int second = ReadPositive("Введите второе число: ");
Console.WriteLine($"Сумма: {first + second}");

while (true)
{
    Console.WriteLine("\n1. Сложить два числа");
    Console.WriteLine("2. Максимум из двух");
    Console.WriteLine("3. Факториал");
    Console.WriteLine("0. Выход");
    Console.Write("Выберите пункт: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            int a = ReadPositive("Первое число: ");
            int b = ReadPositive("Второе число: ");
            Console.WriteLine($"Сумма: {Sum(a, b)}");
            break;
        case "2":
            int x = ReadPositive("Первое число: ");
            int y = ReadPositive("Второе число: ");
            Console.WriteLine($"Максимум: {Max(x, y)}");
            break;
        case "3":
            int f = ReadPositive("Число для факториала: ");
            Console.WriteLine($"Результат: {Factorial(f)}");
            break;
        case "0":
            return;
        default:
            Console.WriteLine("Нет такого пункта");
            break;
    }
}

Console.WriteLine(Lcm(4, 6));