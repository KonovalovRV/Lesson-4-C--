int[] array = { 9, 9, 8, 9 };
int max1 = array[0];
int max2 = array[0];
int length = array.Length;
for (int index = 1; index < length; index++)
{
    if (array[index] > max1)
    {
        max1 = array[index];
    }
    else if (max2 == max1)
    {
        max2 = array[index];
    }
    if (array[index] > max2)
    {
        max2 = array[index];
    }
}
Console.WriteLine(max1);
Console.WriteLine(max2);
