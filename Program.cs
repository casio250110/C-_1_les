// See https://aka.ms/new-console-template for more information
/*
Console.Write("Введите имя: ");
string name = Console.ReadLine();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Квадрат {number} равен {number*number}");
Console.WriteLine("Ваше имя "+name);
*/
/*
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
if (num2*num2==num1)
    Console.WriteLine($"{num1} является квадратом {num2}");
else 
    Console.WriteLine("Нет, не является");
int koren = Convert.ToInt32(Math.Sqrt(num1));
if (koren == num2){
    Console.WriteLine($"{num1} является квадратом {num2}");
}
else {
    Console.WriteLine("Нет, не является");
}
*/
/* Программа будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/
/*
Console.Write("Введите номер: ");
int num = int.Parse(Console.ReadLine());
if (num==1) Console.WriteLine("Понедельник");
else if (num==2)Console.WriteLine("Вторник");
else if (num==3)Console.WriteLine("Среда");
else if (num==4)Console.WriteLine("Четверг");
else if (num==5)Console.WriteLine("Пятница");
else if (num==6)Console.WriteLine("Суббота");
else if (num==7)Console.WriteLine("Воскресенье");
else Console.WriteLine("Такого дня недели не существует:(");
*/
//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа от -N до N.
int N = int.Parse(Console.ReadLine());
int M = -N;
while (M!=N){
    Console.WriteLine(M);
    M+=1;
}
Console.WriteLine(M);