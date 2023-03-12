// задача 10
Console.Write("Введите число:  ");
int n = Convert.ToInt32(Console.ReadLine());
int n2 = n % 100;
int n3 = n2 / 10;
Console.Write($"вторая цифра трехзначного числа: {n3}");
