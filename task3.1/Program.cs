//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num;
int count = 0;
int res = 0;
while (num > 0)
{
    count++;
    num = num / 10;
}
if(count<3)
    Console.WriteLine($"{num2} - в данном числе третьей цифры нет");
else
{
    for (int i= 0; i<3; i++)
{ 
    count = count-1;
    int a = 0, b=1, c=10, n = count;
    while (a != n)
    { 
      a++;
      b = b*c;  
    }
    res=num2/b;
    res=res % 10;
}
Console.WriteLine($"{res} - третья цифра введенного числа");
}
