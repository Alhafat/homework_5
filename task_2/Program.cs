// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] GetArray ()
{
    System.Console.WriteLine("Введите количество значений массива:");
    int size=int.Parse(Console.ReadLine()!);
    int[] array=new int[size];
    for (int i = 0; i <size; i++)
    {
        array[i]=new Random().Next(100,1000);
    }
    return array;
}

int findNumbers(int[] numbers, int summ)
{
    for (int i =1; i <numbers.Length; i++)    
    {
        summ+=numbers[i];
    }
    return summ;
}

int[] numbers=GetArray();
System.Console.WriteLine(string.Join(", ", numbers));
int result=findNumbers(numbers, summ);
System.Console.WriteLine(string.Join(", ", result));