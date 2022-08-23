
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int t = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int[m,n,t];

int[] numbers = new int[m*n*t];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(10,100);
    int temp = numbers[i];
    for (int j = 0; j <  i; j++)
    {
        while (numbers[i] == numbers [j])
        {
            numbers[i] = new Random().Next(10,100);
            temp = numbers[i];
            j = 0;
        }   
    }
}

int counter = 0;

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    { 
        for (int k = 0; k < t; k++)
        {
         array[i,j,k] = numbers[counter];
         counter++;   
         Console.WriteLine(array[i,j,k] + 
         "(" + i + ", " + j  + ", " + k + ")");
        }
    }
}
Console.WriteLine();

// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m,n];

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         int num = new Random().Next(0, 100);
        
//          array[i,j] = num;   
//          Console.WriteLine(array[i,j] + 
//          "(" + i + ", " + j + ")");
//     }
// }
// Console.WriteLine();

