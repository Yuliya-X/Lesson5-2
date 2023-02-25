
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// рандомный массив случайных чисел с выводом в печать элеметнов массива 
void Main()
{
double[] array = new double[5]; // длина массива 5 
Random random = new Random(); // наполняем массив 
double max = GetMax(array);
double min = GetMin(array);
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 99); // ограничила от 0 до 99 числа 
    }
Console.Write("Массив: "); // Выводим массива в печать 
    foreach (int item in array) // перебор по элементам массива в порядке возрастания индекса 
    {
        Console.Write(item + " "); // выводим элементы массива 
    }
Console.WriteLine(); // пустая строка 
Console.WriteLine("Разница между максимальным и минимальным значением в массиве: " + GetDif(array)); 
// пишу dif, полученную в GetDif полностю названием метода 
// GetDif потерял значения max, min, внесла через = названиями методов (см.ниже)
}

// Метод, который возвращает максимальный элемент массива
double GetMax(double[] array)
{
double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
           {
                max = array[i];
           }
    }
    return max;
}

// Метод, который возвращает минимальный элемент массива
double GetMin(double[] array)
{
double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
           {
                min = array[i];
           }
    }
    return min;
}

// Метод, который возвращает разницу максимального и минимального элементов массива
double GetDif(double[] array)
{
    double dif;
    double max = GetMax(array);
    double min = GetMin(array);
    dif = max - min;
// добавила int double max = GetMax(array); и double min = GetMin(array); для расчета dif, проблема стыковки ушла
    return dif;
}

Main();
