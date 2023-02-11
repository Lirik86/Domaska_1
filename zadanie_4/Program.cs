Console.WriteLine("Введите число: ");
string i = Console.ReadLine();
int number = Convert.ToInt32(i);
int count1 = 1;
int count2 = -1;
while(count2 >= number)
{
    if (count2 % 2 == 0)
    {
        Console.Write($"{count2} ");
        count2 = count2 - 1;
    }
    else
    {
        count2 = count2 - 1;
    }
}
while(count1 <= number)
{
    if (count1 % 2 == 0)
    {
        Console.Write($"{count1} ");
        count1++;
    }
    else
    {
        count1++;
    }
}
