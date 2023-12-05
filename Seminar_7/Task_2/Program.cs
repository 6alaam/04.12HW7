


Main();

void Main()
{
    bool isWork = true;
    while (isWork)
    {
        Console.WriteLine("enter command");
        string command = Console.ReadLine();
        switch (command)
        {
            case "Task 46":
                Task46();
                break;
            case "Task 48":
                Task48();
                break;
            case "Task 49":
                Task49();
                break;
            case "Task 51":
                Task51();
                break;
            // case "Task 36":
            //     Task36();
            //     break;
            // case "Task 38":
            //     Task38();
            //     break;
            case "exit":
                isWork = false;
                break;

        }
    }
}

// задайте целый двумерный массив размером m*n заполненный случайными числами (целыми)

void Task46()
{

    Console.WriteLine("Task 46");
    System.Console.WriteLine("Введите число строк m");
    int m = ReadInt("m");
    System.Console.WriteLine("Введите число столбцов n");
    int n = ReadInt("n");
    int[,] array = CreateBenaryArray(m, n, 10, 99);
    PrintArray(array);

}

// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: A = m+n.
// Выведите полученный массив на экран.


void Task48()
{
    Console.WriteLine("Task 48");
    System.Console.WriteLine("Введите число строк m");
    int m = ReadInt("m");
    System.Console.WriteLine("Введите число столбцов n");
    int n = ReadInt("n");
    int[,] array = CreateSumMNelementsArray(m, n);
    PrintArray(array);



}


// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

void Task49()
{
    Console.WriteLine("Task 49");
    System.Console.WriteLine("Введите число строк m");
    int m = ReadInt("m");
    System.Console.WriteLine("Введите число столбцов n");
    int n = ReadInt("n");
    int[,] array = CreateBenaryArray(m, n);
    PrintArray(array);
    System.Console.WriteLine(" Переделанный массив");
    EvenNumberedSquare(array);
    PrintArray(array);

}

// Задача 51: Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.


void Task51()
{
    Console.WriteLine("Task 51");
    System.Console.WriteLine("Введите число строк m");
    int m = ReadInt("m");
    System.Console.WriteLine("Введите число столбцов n");
    int n = ReadInt("n");
    int[,] array = CreateBenaryArray(m, n);
    PrintArray(array);
    Console.Write("сумма главной диангонали ");
    
    Console.WriteLine(ArrayDiagonalSum(array));

}








int ReadInt(string argument)
{

    Console.Write($"Input {argument}: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {

        Console.WriteLine("Не число введите число!");

    }
    return number;

}

void PrintArray(int[,] matr)        /// печать двумерного массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();

    }
}


int[,] CreateBenaryArray(int m, int n, int min = 2, int max = 6)
{

    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {



        for (int j = 0; j < n; j++)
        {

            array[i, j] = new Random().Next(min, max + 1);
        }

    }
    return array;
}

int[,] CreateSumMNelementsArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {



        for (int j = 0; j < n; j++)
        {

            array[i, j] = i + j;
        }

    }
    return array;

}


int[,] EvenNumberedSquare(int[,] array)
{
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] = (array[i, j]) * (array[i, j]);
            }

        }

    }
    return array;
}

int ArrayDiagonalSum(int[,] array)
{

    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += array[i,j];
            }

        }

    }
    return sum;

}

