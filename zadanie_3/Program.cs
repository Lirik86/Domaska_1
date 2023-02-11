Console.WriteLine("Введи число: ");
string number11 = Console.ReadLine();
int number1 = Convert.ToInt32(number11);
if (number1 % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}