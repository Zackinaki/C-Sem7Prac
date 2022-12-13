// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
//  в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void InputMatrix(int[, ] matrix)
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
Console.Write("Vvedite rasmer massiva: ");
string[] coord = Console.ReadLine().Split(" ");
int row = int.Parse(coord[0]);
int column = int.Parse(coord[1]);
int[,] matrix = new int[row, column];
InputMatrix(matrix);


double[] sredArif=new double[column];
 for (int i=0,k=0;i<column;i++) 
            {
                double summa=0;
                for (int j=0;j<row;j++) 
                {
                    summa=summa+matrix[j,i];
                    
                }
                sredArif[k]=summa/row;
                Console.WriteLine($"Среднее арифметическое столбца {k+1}: {Math.Round(sredArif[k],1)}");
                k++;
            }           
    


