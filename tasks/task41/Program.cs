/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 67, 89, 223-> 3
*/
Console.WriteLine("Сколько чисел хотите ввести (значение М): ");
int NumberOfDigits = Convert.ToInt32(Console.ReadLine());
int sum = 0;                 
for (int i = 1; i <= NumberOfDigits; i++)
{
    Console.Write($"{i} число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0)
    {
        sum++;
    } 
}
Console.WriteLine($"Чисел больше нуля -> {sum}");