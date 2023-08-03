// Дан одномерный массив целых однозначных чисел (элемент массива содержит число от 1 до 9).
// Вывести на экран число, которое формируется элементами массива слева-направо + 1.

int[] FillArray(int m)
{
    int[] array = new int[m];

    for (int i = 0; i < m; i++) array[i] =  new Random().Next(1,10);

    return array;
}

// Печать массива

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.GetLength(0) ; i++)
    {
        Console.Write(array[i]);
        if (i != (array.GetLength(0)-1)) Console.Write(", ");
    }
    Console.Write("] + 1 -> ");
}

double ArrayPlusOne(int [] array)
{
    string strValue = "";

    foreach (int i in array) strValue = strValue + i;
    
    return double.Parse(strValue) + 1;
}

//////////////////////////////////////////////////////////////

int[] NewArray = FillArray(5);
PrintArray(NewArray);
Console.Write(ArrayPlusOne(NewArray));