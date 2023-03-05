// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] GenerateArray(int row, int col)
{
    double[,] array = new double[row, col]; // Создаем 2-мерный массив
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
    }
    Console.WriteLine();
}

int InputUser(string message)
{
    System.Console.Write($"{message}  => ");
    return Convert.ToInt32(Console.ReadLine());
}

void AverageforColumn(double[,] array, int row)
{
    double average = 0;
    for (int i = 0; i < array.GetLength(0+1); i++)
    {
        double summ = 0;
        for (int j = 0; j < array.GetLength(1-1); j++)
        {
            summ = summ + array[j, i];
        }
        average = summ / row;
        int num = i + 1;
        Console.WriteLine($" Столбец {num} - среднее = {average:f1};");
    }
}

int i = InputUser("Введите число строк   >");
int j = InputUser("Введите число столбцов  >");
double[,] array = GenerateArray(i, j);
PrintArray(array);
System.Console.WriteLine("-------------------------------------");
if (i == 0 || j == 0)
{
    System.Console.WriteLine("Параметры массива заданы не верно");
}
else AverageforColumn(array, i);
