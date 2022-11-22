// Создадим массив через random
Random rnd = new Random();
int minR = 1; int maxR = 10;
int rows = rnd.Next(minR,maxR); int columns = rows+2; // строки и колонки массива 
int[,] numbers = new int[rows,columns]; // массив
int minRnd = 1; int maxRnd = 10; // для random
//int[] test = {1,4,3,6};
//
FillRandomArray(numbers);
Print2DArray(numbers);

Console.WriteLine();
FindMinSum(numbers);


// Функции
void FindMinSum(int[,] array)
{
    int sum = 0;
    int minSum = 0;
    int indRow = 0;
    for(int row = 0; row < array.GetLength(0); row++)
    {
        for(int col = 0; col < array.GetLength(1); col++)
        {
            sum+=array[row,col];
        }
        if(minSum == 0)
            minSum = sum;
        else if(minSum>sum)
        {
            minSum = sum;
            indRow = row;
        } 
        Console.WriteLine($"Строка {row} сумма {sum}");
        sum = 0;
    }
    Console.WriteLine($"Наименьшая сумма элементов в {indRow} строке, с суммой {minSum}");
}

void FillRandomArray(int[,] array)
{
    Random rnd = new Random();
    for(int row = 0; row < array.GetLength(0); row++)
    {
        for(int col = 0; col < array.GetLength(1); col++)
        {
            array[row,col] = rnd.Next(minRnd,maxRnd);
        }
    }
}

void Print2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {            
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}