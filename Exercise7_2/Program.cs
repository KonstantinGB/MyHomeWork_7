/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return newArray;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        } 
        Console.WriteLine();
    }
}

void ShowArrayIJ(int [,] array, int i, int j)
{
    if(i < array.GetLength(0))
    {
        if(j < array.GetLength(1)) Console.Write(array[i - 1,j - 1]);
        else Console.WriteLine("такого числа в массиве нет");
    }
    else Console.WriteLine("такого числа в массиве нет");
}

Console.Write(" Введите номер строки ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите номер столбца ");
int n = Convert.ToInt32(Console.ReadLine());


int [,] array = CreateRandom2dArray(6, 6, 1, 10);
Show2dArray(array);
ShowArrayIJ(array, m ,n);


