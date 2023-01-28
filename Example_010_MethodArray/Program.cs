// Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find

int[] array = { 1, 6, 154, 48, 0, 89, 74, 32, 1, 654, 87, 61, 40 };

int n = array.Length;
int find = 1;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
Console.WriteLine("The End");
