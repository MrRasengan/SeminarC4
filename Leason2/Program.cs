// Задача 26: Напишите программу, которая принимает на вход число и 
//выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

int Prompt()
{
    Console.WriteLine("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int GetCount(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

int num = Prompt();
Console.WriteLine($"Колличество цифр в числе {num} содержит {GetCount(num)}");