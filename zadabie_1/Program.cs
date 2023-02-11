Console.WriteLine("Введите первое число: ");
string number11 = Console.ReadLine();
int number1 = Convert.ToInt32(number11);
Console.WriteLine("Введите второе число: ");
string number22 = Console.ReadLine();
int number2 = Convert.ToInt32(number22);
if (number1 > number2)
{
    Console.WriteLine($"{number1} больше чем {number2}");
}
if (number2 > number1)
{
    Console.WriteLine($"{number2} больше чем {number1}");
}
if (number1 == number2)
{
    Console.WriteLine($"{number1} равно {number2}");
}