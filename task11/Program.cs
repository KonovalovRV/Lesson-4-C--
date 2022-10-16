// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B (и в нулевую степень). 
// Использовать свои функции, не использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string massage)
{
    Console.WriteLine(massage);
    string number = Console.ReadLine();
    int value = Convert.ToInt32(number);
    return value;
}

int a = Prompt("Введите первое число    ");
int b = Prompt("Введите второе число    ");

int DegreeNumber(int number, int degreenumber)
{
    int f = 1;
    int length = degreenumber;
    for (int i = 0; i < length; i++)
    {
        f = f * number;
    }
return f;
}

Console.WriteLine(DegreeNumber(a,b));
