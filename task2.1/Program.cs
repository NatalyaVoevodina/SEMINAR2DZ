//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели"); // вводится число в промежутке от 1 до 7
int num = Convert.ToInt32(Console.ReadLine());

if(num == 0 || num > 7) 
  Console.WriteLine("Введите число от 1 до 7");
    else if(num >= 1 && num <= 5)
    Console.WriteLine("Рабочий день");
    else if(num == 6 || num == 7)
   Console.WriteLine("Выходной день");
   