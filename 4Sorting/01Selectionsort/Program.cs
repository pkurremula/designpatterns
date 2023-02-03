// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/* 
    Selection sort is an algorithm of sorting an array where it loop from the start of the loop, 
    and check through other elements to find the minimum value. After the end of the first iteration, 
    the minimum value is swapped with the current element. 
    The iteration then continues from the 2nd element and so on.

    https://www.youtube.com/watch?v=g-PGLbMth_g
 */

int array_size =10;
int[] array = new int[10] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
Console.WriteLine("The Array Before Selection Sort is: ");

for (int i = 0; i < array_size; i++)
{
    Console.WriteLine(array[i]);
}

int tmp, min_key;

for (int j = 0; j < array_size - 1; j++)
{
    min_key = j;

    for (int k = j + 1; k < array_size; k++)
    {
        if (array[k] < array[min_key])
        {
            min_key = k;
        }
    }

    tmp = array[min_key];
    array[min_key] = array[j];
    array[j] = tmp;
}

Console.WriteLine("The Array After Selection Sort is: ");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(array[i]);
}

Console.ReadLine();

static void SelectionSort()
{
    
}