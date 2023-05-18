// Задача 28: Напишите программу, которая принимает на вход число N и 
//выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

int Prompt()
{
    Console.WriteLine("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int GetComp(int number)
{
    int comp = 1;
    for(int i = 1; i <= number; i++)
    {
        comp = comp * i;
    }
    return comp;
}

int num = Prompt();
Console.WriteLine($"Произведение чисел от 1 до {num} равна = {GetComp(num)}");