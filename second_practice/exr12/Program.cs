// порграмма, которая принимает на вход два числа и выводит, является ли второе число кратным первому. Если число 2 не кратно числу 1, то выводится остаток от деления
// например: 34, 5 -> не кратно, остаток 4;  16, 4 -> краатно

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0)
{
    Console.WriteLine($"{num1}, {num2} -> кратно");
}
else
{
    Console.WriteLine($"{num1}, {num2} -> не кратно, остаток {num1 % num2}");
}