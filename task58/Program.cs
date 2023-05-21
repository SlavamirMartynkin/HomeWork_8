//Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

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
double[,] FillMatrix(double[,] matr) // заполняет матрицу случайными числами
{
    Random rnd =new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = rnd.Next(1, 3);
        }
    }
    return matr;
}
void PrintMatrix(double[,] matr)  // выводит матрицу на экран
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
double[,] MultiplicationMatrix(double[,] matr1, double[,] matr2)
{
    double[,] matrRes = new double[matr1.GetLength(0),matr2.GetLength(1)];
    for (int i = 0; i < matrRes.GetLength(0); i++)
    {
        for (int j = 0; j < matrRes.GetLength(1); j++)
        {
            for (int k = 0; k < matrRes.GetLength(0); k++)
            {
                matrRes[i, j] += matr1[i, k] * matr2[k, j]; 
            }   
        }
    }
    PrintMatrix(matrRes);
    return matrRes;
}



int str = ReadInt("Введите количество строк: ");
int coll = ReadInt("Введите количество стольбцов: ");
if (str != coll) System.Console.WriteLine("Матрицы должны быть квадратными.");
else
{
    double[,] array1 = new double[str, coll];
    double[,] array2 = new double[str, coll];
    FillMatrix(array1);
    PrintMatrix(array1);
    System.Console.WriteLine(" x");
    FillMatrix(array2);
    PrintMatrix(array2);
    System.Console.WriteLine(" ||");
    
    MultiplicationMatrix(array1, array2);

}
