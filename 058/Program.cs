void FillArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
    array[i,j] = new Random().Next(0, 10);
    Console.Write("{0}\t", array[i,j]);
    }
Console.WriteLine();
}
Console.WriteLine();
}

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());

while (a != c || b!= d)
{
Console.WriteLine("Impossible");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
d = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();
int[,] FirstMatrix = new int[a,b];
int[,] SecMatrix = new int[c,d];
Console.WriteLine("Array 1");
FillArray(FirstMatrix);
Console.WriteLine("Array 2");
FillArray(SecMatrix);

void Product(int[,] ar1, int[,] ar2)
{
int[,] ArrSum = new int[ar1.GetLength(0), ar1.GetLength(1)]; 
for (int i = 0; i < ar1.GetLength(0); i++)
{
    for (int j = 0; j < ar1.GetLength(1); j++)
    {
    ArrSum[i,j] = ar1[i,j]*ar2[i,j];
    Console.Write("{0}\t", ArrSum[i,j]);
    }
Console.WriteLine();
}
Console.WriteLine();
}

Console.WriteLine("Production array");
Product(FirstMatrix,SecMatrix);