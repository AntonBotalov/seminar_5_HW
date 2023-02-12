// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Task_1()
{
    int[] array = GetRandomArray(5, 100, 999);
    int count = findNumber(array);
    Console.WriteLine($"Введен массив [{string.Join(", ", array)}] - {count} четных чисел");
}

void Task_2()
{
    int[] array = GetRandomArray(4, -10, 10);
    int sum = sumOddNumber(array);
    Console.WriteLine($"Введен массив [{string.Join(", ", array)}] - {sum} сумма элементов на нечетной позиции");
}

void Task_3()
{
    int[] array = GetRandomArray(4, 0, 99);
    int max = maxNumberArray(array);
    int min = minNumberArray(array);
    Console.WriteLine($"Введен массив [{string.Join(", ", array)}] \n min = {min} \n max = {max} \n разница между min и max = {max - min}");
}

int[] GetRandomArray(int Length, int minElement, int maxEliment)
{
    int[] array = new int[Length];
    Random random = new Random();

    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minElement, maxEliment+1);
    }
    return array;
}

int findNumber(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
           count++;
        }
    }
    return count;
}

int sumOddNumber(int[] array)
{
    int sum = 0;

    for (int i = 0;  i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            sum += array[i];
            i++;
        }
        else 
        {
            i++;
        }
    }
    return  sum;
}

int maxNumberArray(int[] array) 
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

int minNumberArray(int[] array) 
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

bool inWork = true;

while (inWork)
{
    Console.Write("Выбери задачу ");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch(i)
        {
            case 1:
            {
                Task_1();
                
                break;
            }

	    case 2:
            {
                Task_2();
                
                break;
            }

            case 3:
            {
                Task_3();
                
                break;
            }

            case -1: inWork = false; break;
        }
    }
}
