// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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

int findNumbers(int[] numbers)
{
    int count=0;
    foreach (int number in numbers)
    {
        count+=number%2==0? 1:0;
    }
    return count;
}

int[] numbers=GetArray();
System.Console.WriteLine(string.Join(", ", numbers));
int result=findNumbers(numbers);
System.Console.WriteLine(string.Join(", ", result));