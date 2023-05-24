int[] array = { 3, 45, 66, 76, 38, 26, 8, 2, 38 };

int n = array.Length;
int find = 38;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}
