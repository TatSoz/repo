/* Найдите максимальное из 9 чисел  */

// задаем функцию

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 37;
int b1 = 86;
int c1 = 98;
int a2 = 89;
int b2 = 346;
int c2 = 67;
int a3 = 39;
int b3 = 74;
int c3 = 53;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max( max1, max2, max3);

Console.WriteLine(max);

