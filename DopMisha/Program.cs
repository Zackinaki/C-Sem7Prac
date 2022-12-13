// Миша уже научился хорошо фотографировать и недавно увлекся программированием. Первая программа,
//  которую он написал, позволяет формировать негатив бинарного черно-белого изображения.
// Бинарное черно-белое изображение – это прямоугольник, состоящий из пикселей, каждый из которых 
// может быть либо черным, либо белым. Негатив такого изображения получается путем замены каждого
//  черного пикселя на белый, а каждого белого пикселя – на черный.
// Миша, как начинающий программист, написал свою программу с ошибкой, поэтому в результате ее 
// исполнения мог получаться некорректный негатив. Для того чтобы оценить уровень несоответствия
//  получаемого негатива исходному изображению, Миша начал тестировать свою программу.
// В качестве входных данных он использовал исходные изображения. Сформированные программой 
// негативы он начал тщательно анализировать, каждый раз определяя число пикселей негатива, 
// которые получены с ошибкой.
// Требуется написать программу, которая в качестве входных данных использует исходное бинарное
//  черно-белое изображение и полученный Мишиной программой негатив, и на основе этого определяет
//   количество пикселей, в которых допущена ошибка.

void InputMatrix(string[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Console.ReadLine(); 
            
        }
        
    }
}

void PrintMatrix(string[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
            
        }
        Console.WriteLine();
    }
}

void SravnMatrix(string[, ] matrix,string[, ] matrixb)
{
    int k=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j]==matrixb[i,j])
            k++;
            
            
        }
        
    }
    Console.Write(k);
}

Console.Clear();
Console.Write("Vvedite rasmer izobrazhenia: ");
string[] coord = Console.ReadLine().Split(" ");
int row = int.Parse(coord[0]);
int column = int.Parse(coord[1]);
string[,] matrix = new string[row, column];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
string[,] matrixb = new string[row, column];
InputMatrix(matrixb);
PrintMatrix(matrixb);
Console.WriteLine();
SravnMatrix(matrix,matrixb);