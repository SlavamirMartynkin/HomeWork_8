//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Fill3DMatrix()
{
    Dictionary<int, int> dict = new Dictionary<int, int>();
    int[,,] matrix = new int[2,2,2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int rnd = new Random().Next(10, 100);
                while (dict.ContainsKey(rnd)) 
                {
                    rnd = new Random().Next(10, 100);
                }
                dict.Add(rnd, 1);
                matrix[i, j, k] = rnd;
            }
        }
    }
    return matrix;
}
void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.WriteLine($"{matrix[i, j, k]} ({i},{j},{k})");
            }
        }

    }
}

Print3DMatrix(Fill3DMatrix());
