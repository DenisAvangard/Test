string[] array = new string[5] { "1234", "3571", "gb", "don", "red" };
string[] SortingArr = new string[array.Length];

void ArraySorting(string[] array, string[] SortingArr)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            SortingArr[count] = array[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

ArraySorting(array, SortingArr);
PrintArray(SortingArr);