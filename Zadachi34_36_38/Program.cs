//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

/*
Console.WriteLine("Вас приветствует программа подсчета количества чётных чисел в массиве:");
Console.Write("Введите длину массива L = ");
int l = int.Parse(Console.ReadLine());

int[] array = GetRandomArray(l);

int a = GetEvenNubers(array);


PrintArray(array, a);


int[] GetRandomArray(int l)

{
    Random random = new Random();
    int[] array = new int[l];


    for (int i = 0; i < l; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}


int GetEvenNubers(int[] array)
{
    int a = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            a++;
        }
    }

    return a;

}

void PrintArray(int[] array, int a)
{
    Console.WriteLine($"[{string.Join(" ,", array)}] -> {a}");
}
*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
/*
Console.WriteLine("Программа подсчета суммы нечётных элементов массива");
Console.Write("Введите длинну массива L = ");
int l = int.Parse(Console.ReadLine());


int[] array = GetRandomArray(l);

int a = GetSumOfOddNubers(array);

PrintArray(array, a);




int[] GetRandomArray(int l)

{
    Random random = new Random();
    int[] array = new int[l];


    for (int i = 0; i < l; i++)
    {
        array[i] = random.Next(0, 100);
    }
    return array;
}

int GetSumOfOddNubers(int[] array)
{
    int a = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 > 0)
        {
            a = a + array[i];
        }
    }

    return a;

}

void PrintArray(int[] array, int a)
{
    Console.WriteLine($"[{string.Join(" ,", array)}] -> {a}");
}


*/

//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

Console.Write("Введите длинну массива: L = ");
int l = int.Parse(Console.ReadLine());

int[] array = GetRandomArray(l);
int min = GetMinNumber(array);
int max = GetMaxNumber(array);
PrintArray(array, min, max);


int[] GetRandomArray(int l)

{
    Random random = new Random();
    int[] array = new int[l];


    for (int i = 0; i < l; i++)
    {
        array[i] = random.Next(0, 100);
    }
    return array;
}

int GetMinNumber(int[] array)
{

    int min = array[0];



    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }

    return min;

}

int GetMaxNumber(int[] array)
{
    int max = array[0];



    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }

    return max;
}


void PrintArray(int[] array, int min, int max)
{
    Console.WriteLine($"[{string.Join(" ,", array)}] -> {max - min}");
}




