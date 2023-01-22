//Даны два числа. Показать большее и меньшее число

//Первый способ (с вводом чисел с клавиатуры):

Console.Clear();

Console.WriteLine("Первый способ (с вводом чисел с клавиатуры):");
Console.WriteLine();

Console.Write("Ведите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("Большее число = " + number1);
    Console.WriteLine("Меньшее число = " + number2);
}
else
{
    Console.WriteLine("Большее число = " + number2);
    Console.WriteLine("Меньшее число = " + number1);
}
Console.WriteLine();







//Второй способ (через рандомайзер):

Console.WriteLine("Второй способ (через рандомайзер):");
Console.WriteLine();

int numberA = new Random().Next(100);
int numberB = new Random().Next(100);

Console.WriteLine("Первое число = " + numberA + "   Второе число = " + numberB);
Console.WriteLine(" ");

if (numberA > numberB)
{
    Console.WriteLine("Большее число = " + numberA);
    Console.WriteLine("Меньшее число = " + numberB);
}
else
{
    Console.WriteLine("Большее число = " + numberB);
    Console.WriteLine("Меньшее число = " + numberA);
}
