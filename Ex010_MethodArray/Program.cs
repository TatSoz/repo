/*  Имеется одномерный массив array из n элементов, требуется найти элемент массива равный find. */

int[] array = {9, 3, 1, 7, 9, 2, 4};

int n = array.Length;
int find = 7;

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