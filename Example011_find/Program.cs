int[] array = { 11, 31, 24, 35, 54, 6, 4, 88 };

int n = array.Length;
int find = 88;

int index = 0;
while (index < n)
{
    if (array[index] == find)
    { 
        Console.WriteLine(index);
    }
    index++;
}