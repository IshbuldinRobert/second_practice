// Сортировка массива

void PrintArr(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        if (i == 0) Console.Write($"[{mass[i]}, ");
        else if (i == mass.Length - 1) Console.WriteLine($"{mass[i]}]");
        else Console.Write($"{mass[i]}, ");
    }
}

Console.WriteLine("Сколько элементов в массиве будет: ");
int size = Convert.ToInt32(Console.ReadLine());



int[] arr = new int[size];
int ind = 0;

Console.WriteLine("Введите элементы массива: ");
while (ind < size)
{
    arr[ind] = Convert.ToInt32(Console.ReadLine());
    ind++;
}
Console.Write("Полученный массив: ");
for (int i = 0; i < size; i++)
{
    if (i == 0) Console.Write($"[{arr[i]}, ");
    else if (i == arr.Length - 1) Console.WriteLine($"{arr[i]}]");
    else Console.Write($"{arr[i]}, ");
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temprary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temprary;
    }
}

SelectionSort(arr);
Console.Write("Отсортированный массив: ");
PrintArr(arr);