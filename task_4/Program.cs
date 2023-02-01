// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сортировку.

// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]

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

int[] sortNumbers(int[] numbers)
{
    int size=numbers.Length;
    // int[] newnumbers=new int[0];
    int temp;
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        for (int j = i + 1; j < numbers.Length; j++)
        {
        if (numbers[i] < numbers[j])
        {
            temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
        }
    }
    return numbers;
}

int[] numbers=GetArray();
System.Console.WriteLine(string.Join(", ", numbers));
int[] result=sortNumbers(numbers);
System.Console.WriteLine(string.Join(", ", result));