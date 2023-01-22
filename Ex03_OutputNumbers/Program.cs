// Показать числа от -N до N

Console.Clear();

//Первый способ (через оператор "while"):

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

int negN = -N;

while (negN <= N)
{
    Console.Write(negN + "  ");
    negN++;
}
Console.WriteLine();


//Второй способ (через цикл "for"):
Console.WriteLine();
int H = new Random().Next(10);
Console.WriteLine("Случайное число N: ");
Console.WriteLine(H);

for (int i = -H; i <= H; i++)
{
    Console.Write(i + "  ");
}

