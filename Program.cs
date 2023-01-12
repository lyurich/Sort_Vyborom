// Console.Write("Введите размерность массива: ");
// int size = int.Parse(Console.ReadLine()!);

// int[] array = GetArray(size, -9, 9);
// Console.WriteLine($"Изначальный массив: [{String.Join(", ", array)}]");

// for (int i = 0; i < size - 1; i++)
// {
//     int MinIndex = i;
//     for (int j = i + 1; j < size; j++)
//     {
//         if (array[j] < array[MinIndex])
//             MinIndex = j; 
//     }
//     int temp;
//     temp = array[MinIndex];
//     array[MinIndex] = array[i];
//     array[i] = temp;
// }
// Console.WriteLine("Конечный массив: [" + string.Join(", ", array) + "]");

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

Console.WriteLine("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(-10, 10);
}
Console.WriteLine($"Изначальный массив: [{string.Join(" ,", array)}]");

for (int i = 0; i < n - 1; i++)
{
    int min = i;
    for (int j = i + 1; j < n; j++)
    {

        if (array[j] < array[min])
            min = j;
        
    }
    int temp;
    temp = array[min];
    array[min] = array[i];
    array[i] = temp;

}
Console.WriteLine($"Отсортированный массив: [{string.Join(" ,", array)}]");