// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Random rnd = new Random();
int count = rnd.Next(1, 10);
Console.WriteLine($"Количество: {count}");
int size = count;
int[] numbers = new int[size];
for(int i = 0; i < size; i++)
{
    Console.Write($"Введите {i+1} число: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]} ");
}
Console.WriteLine();

int counter = 0;
for ( int i = 0; i < size; i++)
{
   if (numbers[i]>0)counter++;
}
Console.WriteLine($"Количество чисел больше 0 - {counter}.");