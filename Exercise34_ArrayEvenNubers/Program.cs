/* определяет массив размером 4 и присваивает его элементам
 случайные целочисленные значения от 100 до 999, используя метод getArray*/
int[] array = GetArray(4, 100, 999);

/* подсчитывает количество четных чисел в массиве и присваивает значение count 
переменной countNumbers, используя метод GetCountEvenNumbers*/
int countNumbers = GetCountEvenNumbers(array);

// выводит массив целых чисел и количество четных чисел в нем на консоль
Console.Write($"В массиве [{String.Join(", ", array)}] четных чисел -> {countNumbers}");

/* метод, который генерирует целочисленный массив заданного размера
и со случайными целочисленными значениями между параметрами MinValue и MaxValue*/
int[] GetArray(int size, int minValue, int maxValue)
{

    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);

    }
    return array;
}

/* метод, который подсчитывает количество четных целых
 чисел в массиве, передаваемом в качестве аргумента*/
int GetCountEvenNumbers(int[] arr)
{
    int evenCount = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0) evenCount += 1;
    }
    return evenCount;
}
