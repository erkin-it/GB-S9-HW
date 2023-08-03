// Дан одномерный массив целых чисел, элементом которого, может быть либо 1, либо 0.
// Вывести на экран максимальное количество следующих друг за другом 1.

int[] FillArray(int m)
{
    int[] array = new int[m];

    for (int i = 0; i < m; i++) array[i] =  new Random().Next(0,2);

    return array;
}

// Печать массива

void PrintArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0) ; i++)
    {
        Console.Write(string.Format("{0,2}", array[i]));
    }
    Console.WriteLine();
}

//Поиск максимального количества следующих друг за другом 1.

int CountMaxSeries (int[] array)
{
    int maxSeries = 0;
    int countSeries = 0;
    bool series = true;

    for (int i = 0; i < array.GetLength(0) ; i++)
    {
        if (array[i] == 0)
        {
            countSeries=0;
            series = false;
        }
        else
        {
            countSeries++;
            series = true;
        }

        if (series && countSeries>maxSeries && countSeries>1) maxSeries=countSeries;
    }
    return maxSeries;
}

/////////////////////////////////////////////////////////////

int[] NewArray = FillArray(10);
PrintArray(NewArray);
Console.WriteLine($"Result: {CountMaxSeries(NewArray)}");