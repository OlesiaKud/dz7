// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
void FillMatrixWhithRandomNumbers(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 11);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} " + "\t");
        }
        System.Console.WriteLine();
    }
}

System.Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

FillMatrixWhithRandomNumbers(matrix);
PrintMatrix(matrix);
System.Console.WriteLine("Предлагаем в этом массиве найти элемент.");
System.Console.WriteLine("Если вы желаете указать его позицию в массиве, и получить численное значение, то ввведите 1.");
System.Console.WriteLine("Если желаете ввести численное значение, а на выходе получить позицию этого элемента в массиве, то введите 2.");
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
        Console.Write("Укажите в данном массиве номер строки: ");
        int row = Convert.ToInt32(Console.ReadLine()) - 1;
        Console.Write("Укажите в данном массиве номер строки: ");
        int column = Convert.ToInt32(Console.ReadLine()) - 1;


        if (row < 0 | row > matrix.GetLength(0) - 1 | column < 0 | column > matrix.GetLength(1) - 1)
        {
            Console.WriteLine("Элемент не существует.");
        }
        else
        {
            Console.WriteLine($"Значение элемента массива = {matrix[row, column]}");
        }
        break;

    // case 2:
    //     System.Console.Write("Введите число, которое ищем в указанном массиве: ");
    //     int num = Convert.ToInt32(Console.ReadLine());
    //     int temp = 0;
    //     for (int i = 0; i < matrix.GetLength(0); i = i++)
    //     {
    //         for (int j = 0; j < matrix.GetLength(1); j = j++)
    //         {
    //             if (matrix[i, j] == num)
    //             {
    //                 Console.WriteLine($"Позиция элемента {num}: [{i}, {j}]");
    //                 temp++;
    //             }
    //         }
    //     }
    //     if (temp != 0)
    //     {
    //         Console.WriteLine($"Элемента {num} нет в массиве");
    //     }

    //     break;

    default:
        Console.WriteLine("Необходимо указать либо 1 либо 2");
        break;

}




