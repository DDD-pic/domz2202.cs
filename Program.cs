//Напишите цикл, который принимает на вход два числа (A и B)
 //и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

/*Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  число b");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;

for (int i = 1; i < b; i++)
{
step = step * a;
}
  
Console.WriteLine("a в степени b: " + step);
*/



/*Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
Console.WriteLine("Введите число a");
int number = Convert.ToInt32(Console.ReadLine()); 
int sum = 0;

int firstValu = number / 1000;
int secondValue = number  % 10;
int numValue = (number / 10) % 10;

sum = (secondValue + firstValu + numValue);
Console.WriteLine(sum);
/*Задача 29: Напишите программу, которая задаёт массив из 8 
элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
