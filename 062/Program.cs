int m = 4;
int[,] array = new int[m,m];

int StartRow = 0;
int StartCol = 0;
int EndRow = m-1;
int EndCol = m-1;
int k = 1;

while(StartCol <= EndCol && StartRow <= EndRow)
{
    for (int i = StartCol; i <= EndCol; i++)
    {
        array[StartRow, i] = k;
        k++;
    }
    StartRow++;
    for (int j = StartRow; j <= EndRow; j++)
    {
        array[j, EndCol] = k;
        k++;
    }
    EndCol--;
    for (int i = EndCol; i >= StartCol; i--)
    {
        array[EndRow, i] = k;
        k++;
    }
    EndRow--;
    for (int j = EndRow; j >= StartRow; j--)
    {
        array[j, StartCol] = k;
        k++;
    }
    StartCol++;

}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
    Console.Write("{0}\t", array[i,j]);
    }
Console.WriteLine();
}


