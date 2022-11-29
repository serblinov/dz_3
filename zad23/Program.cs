/*Напишите программу, которая принрмает на вход число N, а выдает таблицу кубов чисел от 1 до N/
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

for(int i = 1; i <= N; i++)
{
    Console.WriteLine(i*i*i);
}

