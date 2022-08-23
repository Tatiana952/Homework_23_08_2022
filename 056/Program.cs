int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
    array[i,j] = new Random().Next(0, 5);
    Console.Write("{0}\t", array[i,j]);
    }
Console.WriteLine();
}
Console.WriteLine();

int FindMinSum(int[,] matrix, int RowNumb)
{
    int[] ArrSum = new int [RowNumb];
    for (int i = 0; i < m; i++)
        {
        int sum = 0;
        for (int j = 0; j < n; j++)
            {
                sum += array[i,j];
            }
        ArrSum[i] = sum;
        }
    int MinSum = 0;
    for (int i = 1; i < ArrSum.Length; i++)
        {
            if (ArrSum[i] < ArrSum[MinSum]) MinSum = i;
        }
    return MinSum;
}

Console.WriteLine(FindMinSum(array, m) + " line");
