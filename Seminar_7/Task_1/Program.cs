// здесь разбор задач из 4 и 5 семинаров но уже собранные в одну прогу и визуально понятное отображение

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
            case "Task 25":
                Task25();
                break;
            case "Task 27":
                Task27();
                break;
            case "Task 29":
                Task29();
                break;
            case "Task 34":
                Task34();
                break;
            case "Task 36":
                Task36();
                break;
            case "Task 38":
                Task38();
                break;
            case "exit":
                isWork = false;
                break;

        }
    }
}

// задача 25 , напишите цикл,который принемает на вход два числа (A и В)
//  и возводит а в степень б

void Task25()
{
    System.Console.WriteLine("Task 25");

    int number = ReadInt("number");
    int pow = ReadInt("Pow");

    Console.WriteLine("Pow:");

    Console.WriteLine(Pow(number, pow));

    Console.WriteLine("RecPow:");
    Console.WriteLine(PowRecursion(number, pow));


}
// принемает на вход число и выдает сумму всех числе в нем
void Task27()
{
    Console.WriteLine("Task 27");
    int number = ReadInt("number");
    Console.WriteLine(GetDigitSum(number));

}
// здайте одномерный массив из 8 символов и распечатйте его

void Task29()
{
    Console.WriteLine("Task 29");
    int[] array = CreateArray(8, 1, 10);
    Console.WriteLine(string.Join(", ", array));
}



// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу,
//  которая покажет количество чётных чисел в массиве.


void Task34()
{
    Console.WriteLine("Task 34");
    int length = ReadInt("Length");
    int[] array = CreateArray(length, 100, 1000);
    Console.WriteLine(string.Join(", ", array));
    Console.WriteLine(GetCount(array));

}




// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. Найдите сумму элементов с нечётными индексами.


void Task36()
{
    Console.WriteLine("Task 36");
    int length = ReadInt("Length");
    int[] array = CreateArray(length, 100, 1000);
    Console.WriteLine(string.Join(", ", array));
    Console.WriteLine(GetSum(array));

}

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива

void Task38()
{
    Console.WriteLine("Task 36");
    int length = ReadInt("Length");
    double[] array = CreateDoubleArray(length, 100, 1000);
    Console.WriteLine(string.Join(", ", array));
    Console.WriteLine(GetDifferenceBetweenMinAndMax(array));

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

int Pow(int number, int pow)
{
    int result = 1;
    for (int i = 1; i <= pow; i++)
    {
        result *= number;

    }
    return result;
}
int PowRecursion(int number, int pow)
{
    if (pow <= 1) return number;
    return number * PowRecursion(number, pow - 1);

}

int GetDigitSum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

int[] CreateArray(int length, int min, int max)
{

    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

double[] CreateDoubleArray(int length, int min, int max)
{


    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1) + Math.Round(new Random().NextDouble(), 2);
    }
    return array;



}

int GetCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;

        }

    }
    return count;
}

int GetSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            sum += arr[i];

        }

    }
    return sum;
}

double GetDifferenceBetweenMinAndMax(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        else if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return Math.Round(max - min, 2);
}






