// задача 13
Console.Write("Введите число:  ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
int x = 10;
int number = n;
while (n != 0)
{  
  n = n / 10;
  i = i + 1;
}
Console.WriteLine($"цифр в числе: {i}");
while ( i > 3)
{
  x = x*10;
  i = i - 1;
}
if (i == 1 || i == 2)
  Console.WriteLine("нет третьего числа");
else if (i > 2)
  {
  Console.WriteLine($"делитель: {x}");
  int number1 = number % x;
  int x1 = x/10;
  int number2 = number % x1;
  Console.WriteLine($"третье число =  {(number1 - number2)/x1}");
  }