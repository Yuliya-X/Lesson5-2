﻿// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// рандомный массив случайных чисел 
void Main()
{
int[] array = new int[4]; // длина массива 4 
Random random = new Random(); // наполняем массив 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-9, 19); // ограничила от -9 до 19 числа 
    }
// Выводим массив в печать  
    Console.Write("Массив: ");
    foreach (int item in array) // перебор по элементам массива в порядке возрастания индекса 
    {
        Console.Write(item + " "); // выводим элементы массива 
    }
Console.WriteLine(); // пустая строка 
Console.WriteLine("Сумма элементов под нечётными индексами в массиве: " + Sum(array)); // пишу sum, полученную в Even 
// (если вынести строку вывода результата метода Even из метода Main, теряет связь с array) проверить на другой задаче! ++ 
// если совсем не стыкуется можно добавить int sum = Sum(array); 
}

// Метод, который возвращает сумму элементов массива стоящий на нечётных индексах
int Sum(int[] array)
{
    int sum = 0;
         for (int i = 1; i < array.Length; i += 2) // перебираем массив по нечётным позициям, считаем сумму таких чисел 
         // если надо четные, берем индекс с первого числа (i = 0)
        {
            sum += array[i];
        }
        return sum;
}

Main();
