// // Задача 3: Напишите программу, которая задаёт массив
// из 8 случайных элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 7, 8

int[]array=new int[9];

int[]FillArray(int[]collection)
{
int length=collection.Length;
for(int index=0;index<length;index++)
{
collection[index]=new Random().Next(1,20);
}
return collection;
}

void PrintArra(int[]col)
    {
        for (int index = 0; index < col.Length; index++)
        {
        System.Console.WriteLine($"{col [index]}");  
        }
        System.Console.WriteLine();
    }    

PrintArra (FillArray (array));

