int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
    array[i,j] = new Random().Next(0, 100);
    Console.Write("{0}\t", array[i,j]);
    }
Console.WriteLine();
}
Console.WriteLine();

void SortingInRow(int NumbRow, int[,] matrix)
{
 int k = 0;
    while( k < n-1 )
    {
        int min = k;
        for (int j = k+1; j < n; j++)
        {
            if (matrix[NumbRow,j] < matrix[NumbRow,min]) 
            {
                min = j;
            }
        }
        int temp = matrix[NumbRow,k];
        matrix[NumbRow,k] = matrix[NumbRow,min];
        matrix[NumbRow,min] = temp;
        min = k;
        k++;
    }
}

for (int i = 0; i < m; i++)
{
    SortingInRow(i, array);
}

Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
    Console.Write("{0}\t", array[i,j]);
    }
Console.WriteLine();
}