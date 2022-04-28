
int n = Convert.ToInt32(Console.ReadLine());

int[,] a = new int[n, n];

int m = 1;


for (int i = 0; i < (n / 2); i++)
{
    for (int j = i; j < (n - i); j++)
    {   
        a[i,j] = m;
        m++;
    }
    for (int j = 1; j < (n - i - i); j++)
    {  
        a[(j + i),(n - i) - 1] = m;    
        m++;
    }
    for (int j = (n - 2) - i; j >= i; j--)
    {  
        a[(n - i) - 1,(j)] = m;           
        m++;
    }
    for (int j = ((n - i) - 2); j > i; j--)
    {
        a[j,i] = m;
        m++;
    }
}
if (n % 2 != 0)
{
    Console.WriteLine("НЕ ЧЕТНОЕ значит в центер добавляем последний елемент");
    a[n/2, n/ 2] =n*n;
}



for (int i = 0; i < n; i++)
{
    for ( int j = 0; j < n; j++)
    {
        Console.Write("{0,5}", a[i, j]);
    }
    Console.WriteLine();
}
