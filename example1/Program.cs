// string[,]table = new string [2,3]; // 2 строки и 3 столбца
// int[,] matrix = new int[5,8];

//string[,]table = new string [2,5];
// table[1,2] = "слово"; // индексы идут от 0
// [0,0] [0,1] [0,2] ...
// [1,o] [1,1] [1,2] ...

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"{table[rows,columns]}");
//     }
// }


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // function.GetLength(0/1) - узнаем длину массива 
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine(); // заполнили строку и перешли на новую
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); // [1;10)
        }
    }
}
int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);