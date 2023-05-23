// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

// 1, 2, 5, 7, 19, 4, 76, 3 -> [1, 2, 5, 7, 19,4,76,3]

// 6, 1, 33, 43, 12, 3 ,2, 9 -> [6, 1, 33,43,12,3,2,9]


int[] numbers = new int[8];
for(int i=0; i<numbers.Length; i++)
{
    Random array = new Random();
    numbers[i] = Convert.ToInt32(array.Next(-5, 15));
    Console.WriteLine("El: " +numbers[i]);
}
