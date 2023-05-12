// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int FindNum(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}

if (num < 100)
{
    Console.WriteLine($"Число {num} не имеет третьей цифры");
}
else
    Console.WriteLine($"Третья цифра числа {num} равна {FindNum(num)}");