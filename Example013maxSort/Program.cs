// сортировать массив от меньшего к большему

int [] arr = { 5, 7, 5, 4, 9, 3, 45, 12, 1 };

void PrintArray ( int[] arra)
{
    int count = arra.Length;
  
    for ( int i = 0; i < count; i++)
    {
        Console.Write($"{arra[i]} ");
    }
    Console.WriteLine();
}

void SortMax(int [] ar)
{
    for (int i = 0; i < ar.Length-1; i++)
    {
        int minPos = i;
            for ( int j = i + 1; j < ar.Length; j++)
            {
                if (ar[j] < ar [minPos]) minPos = j;
            }
        int temp = ar [i];
        ar[i] = ar[minPos];
        ar [minPos] = temp;
    }
}

PrintArray(arr);
SortMax(arr);
PrintArray(arr);
