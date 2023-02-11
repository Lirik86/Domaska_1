Console.WriteLine("Введите первое число: ");
string number11 = Console.ReadLine();
int number1 = Convert.ToInt32(number11);
Console.WriteLine("Введите второе число: ");
string number22 = Console.ReadLine();
int number2 = Convert.ToInt32(number22);
Console.WriteLine("Введите третье число: ");
string number33 = Console.ReadLine();
int number3 = Convert.ToInt32(number33);
if (number1 > number2 || number1 > number3)
{
    Console.WriteLine($"{number1} является большим числом");
}
if (number2 > number1 || number2 > number3)
{
    Console.WriteLine($"{number2} является большим числом");
}
if (number3 > number1 || number3 > number2)
{
    Console.WriteLine($"{number3} является большим числом");
}
if (number1 == number2 && number2 == number3)
{
    Console.WriteLine("все три числа равны между собой");
}