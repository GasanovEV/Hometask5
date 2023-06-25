/* определяет массив размером 4 и присваивает его элементам
 случайные вещественные значения от -100 до 100 */
double[] arrayUser = GetArray(5, -100, 100);

/* подсчитывает сумму максимального и минимального элементов массива и 
присваивает значение переменной SummNumbers */
double sumMinMax = GetSumMinMax(arrayUser);

// выводит значения массива и сумму максимального и минимального элементов на консоль
Console.Write($"В массиве [{String.Join(", ", arrayUser)}] сумма минимального и максимального чисел -> {sumMinMax}");

/* метод, который генерирует целочисленный массив заданного размера
и со случайными вещественными значениями между параметрами mnValue и maxValue*/
double[] GetArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];

    for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(rangeFrom, rangeTo) + Math.Round(new Random().NextDouble(), 2);
}
return array;
}

/*метод, который расчитывает сумму максимального
 и минимального элементов массива */
double GetSumMinMax(double[] array)
{
    double max = array[0];
    double min = array[1];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }

    double sum = max + min;
    return sum;
}