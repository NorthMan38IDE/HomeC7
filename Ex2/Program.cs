// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 4
int InputUser(string message) 
{ 
    System.Console.Write($"{message}  => "); 
    return Convert.ToInt32(Console.ReadLine()); 
} 
int[,] GenerateArray(int row, int col) 
{ 
    int[,] array = new int[row, col]; // Создаем 2-мерный массив 
    Random random = new Random(); 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            array[i, j] = random.Next(2, 100); 
        } 
    } 
    return array; 
} 
 
void PrintArray(int[,] array) 
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



int[,] array = GenerateArray(3, 4); 
PrintArray(array); 
int row = InputUser("Введите номер строки массива ....  > "); 
int col = InputUser("Введите номер столбца массива ....  > "); 
if (row <= 0 || col <= 0)
    {
        System.Console.WriteLine("Некорректный ввод. Значения не могут быть равны 0 или меньше 0"); 
        Environment.Exit( 0 );
    }
if (array.GetLength(0)<= row || array.GetLength(1) <= col) 
{
    System.Console.WriteLine("Числа нет в массиве");
}
else System.Console.WriteLine(array[row-1, col-1]);
  


 