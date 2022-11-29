
/*Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
128212 ->да
23432 -> да*/

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int num1 = number / 10000 % 10;
int num2 = number / 1000 % 10;
int num3 = number / 10 % 10;
int num4 = number % 10;
int num5 = number / 10000;        
if (num5 < 1 || num5 > 9)
{
    Console.WriteLine($"Число {number} не пятизначное число");
}
else if  (num1 == num4 && num2 == num3)
{
    Console.WriteLine($"Число {number} - палиндром");
}
 else
{
    Console.WriteLine($"Число {number} - непалиндром");
}