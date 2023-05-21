//Задача 54: Задайте двумерный массив.
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int ReadInt(string argument) // проверка на число
{
    Console.Write(argument);
    int i;
    while (!int.TryParse(Console.ReadLine(), out i))
    {
        System.Console.WriteLine("Это не число!");
        Console.Write(argument);
    }
    return i;
}
int[,] FillMatrix(int[,] matr) // заполняет матрицу случайными числами
{
    Random rnd =new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = rnd.Next(0, 10);
        }
    }
    return matr;
}
void PrintMatrix(int[,] matr)  // выводит матрицу на экран
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
void SortMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {


        int temp = 0;
        for (int m = 0; m < matr.GetLength(1); m++)
        {
            for (int n = m + 1; n < matr.GetLength(1); n++)
            {
                if (matr[i, m] < matr[i, n])
                {
                    temp = matr[i, m];
                    matr[i, m] = matr[i, n];
                    matr[i, n] = temp;
                }
            }
        }


    }
}

int[,] array = new int
    [ReadInt("Введите количество строк: "), 
     ReadInt("Введите количество столбцов: ")];
FillMatrix(array);
System.Console.WriteLine();
PrintMatrix(array);
System.Console.WriteLine();
SortMatrix(array);
PrintMatrix(array);
