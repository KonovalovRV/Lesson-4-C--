// Задача 2: Напишите программу, которая принимает на вход
// число и выдаёт сумму цифр в числе. Функция должна на вход принимать число,
// а выдавать сумму его цифр
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string massage)
{
    Console.WriteLine(massage);
    string number = Console.ReadLine();
    int value = Convert.ToInt32(number);
    return value;
}

int value = Prompt("Введите число   ");

int SumDigitNumber(int number)
{
    int a = 0;
    int b = 0;
    int c = 0;
    int d = 0;
    int sum = 0;

    if (number < 10 || number < 100)
    {
        a = number / 10;
        b = number % 10;
        sum = a + b;
    }
    else
    {
        if (number < 1000)
        {
            a = number / 100;
            b = number % 10;
            c = (number % 100) / 10;
            sum = a + b + c;
        }
        else if (number > 1000 && number < 10000)
        {
            a = number / 1000;
            b = number % 10;
            c = (number / 100) % 10;
            d = (number % 100) / 10;
            sum = a + b + c + d;
        }
        else
        {
        sum = -1;    
        Console.WriteLine("Число выходит за допустимые пределы");
        }
    }
return sum;
}

Console.WriteLine(SumDigitNumber(value));

