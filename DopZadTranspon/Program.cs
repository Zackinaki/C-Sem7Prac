// Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать 
// ее относительно горизонтали.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Vvedite rasmer matrici: ");
string[] coord = Console.ReadLine().Split(" ");
int row = int.Parse(coord[0]);
int column = int.Parse(coord[1]);
int[,] matrix = new int[row, column];
InputMatrix(matrix);
Console.WriteLine();

void ReleaseMatrix(int[,] matrix)
{
    int[,] newmatrix = new int[row, column];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newmatrix[i, j] = matrix[matrix.GetLength(0) - i - 1, j];
            Console.Write($"{newmatrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Trasponirovannai matrica imeet vid: ");
ReleaseMatrix(matrix);