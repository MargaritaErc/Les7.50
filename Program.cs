// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] matrix = new int [new Random().Next(3,5),new Random().Next(3,5)];
for (int i= 0; i< matrix.GetLength(0); i++)
{
   for (int j = 0; j < matrix.GetLength(1); j++)
   {
    matrix [i,j] = new Random().Next(0,12);
    Console.WriteLine(matrix[i,j] + "");
   }
Console.WriteLine();
}
Console.WriteLine("_________");

double sum = 0;
for (int j=0; j<matrix.GetLength(1); j++)
{
    sum+= matrix [i,j];
}
double average = Math.Round(sum/matrix.GetLength(0),2);
sum = 0;
Console.Write(average + " ");
