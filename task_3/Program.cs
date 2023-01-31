// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();

int[] GetArray ()
{
    System.Console.WriteLine("Введите количество значений массива:");
    int size=int.Parse(Console.ReadLine()!);
    System.Console.WriteLine("Введите минимальное значение массива:");
    int minValue=int.Parse(Console.ReadLine()!);
    System.Console.WriteLine("Введите максимальное значение массива:");
    int maxValue=int.Parse(Console.ReadLine()!);
    int[] array=new int[size];
    for (int i = 0; i <size; i++)
    {
        array[i]=new Random().Next(minValue,maxValue+1);
    }
    return array;
}

int summNumbers(int[] numbers)
{
    int max=numbers[0];
    int min=numbers[0];
    int summMaxMin;
    foreach (int number in numbers)
    {
        if (number>max) max=number;
        else if (min>number) min=number;
    }
    summMaxMin=max+min;
    return summMaxMin;
}

int[] numbers=GetArray();
System.Console.WriteLine(string.Join(", ", numbers));
int result=summNumbers(numbers);
System.Console.WriteLine(string.Join(", ", result));