int[,] a = new int[5, 5];
int[,] b = new int [5, 5];
int[,] c =new int [5, 5];
Random rnd = new Random();
 for (int i = 0; i < a.GetLength(0); i++)
{
 for (int j = 0; j < a.GetLength(1); j++)
     {
        a[i, j] = rnd.Next(1, 2);
        Console.Write("{0} ", a[i, j]);
     }
        Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < a.GetLength(0); i++)
{
 for (int j = 0; j < a.GetLength(1); j++)
       {
          b[i, j] = rnd.Next(1, 3);
         Console.Write("{0} ", b[i, j]);
       }
Console.WriteLine();
 }
     Console.WriteLine();

for (int i = 0; i < c.GetLength(0); i++)
 {
  for (int k = 0; k < c.GetLength(1); k++)
 {
  for (int j = 0; j < a.GetLength(1); j++)
         {
           c[i, k] += a[j, k]*b[i, j];  
         }
 Console.Write("{0} ", c[i, k]);
}
    Console.WriteLine();
}
 Console.ReadLine();