//Вывести квадрат числа

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "");
int resaultSquare = number * number;
Console.WriteLine("Квадрат числа " + number + " будет равен " + resaultSquare);