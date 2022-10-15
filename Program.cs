// See https://aka.ms/new-console-template for more information
/*
Console.Write("Введите имя: ");
string name = Console.ReadLine();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Квадрат {number} равен {number*number}");
Console.WriteLine("Ваше имя "+name);
*/
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
