/* определяет массив размером 4 и присваивает его элементам
 случайные целочисленные значения от -100 до 100, используя метод getArray*/
int[] array = GetArray(4, -100, 100);

/* подсчитывает сумму элементов находящихся на четных позициях в массиве и присваивает значение count 
переменной SummNumbers, используя метод GetCountEvenNumbers*/
int sumNumbers = GetSumNumbers(array);

// выводит массив целых чисел и количество четных чисел в нем на консоль
Console.Write($"В массиве [{String.Join(", ", array)}]сумма чисел с четными индексами -> {sumNumbers}");

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
int GetSumNumbers(int[] array)
{
    int sum = 0;
    
    for (int i = 0; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    return sum;
}

