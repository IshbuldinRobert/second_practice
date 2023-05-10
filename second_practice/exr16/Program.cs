// программа принимает на вход два числа и проверяет, является ли одно число квадратом другого
// например: 5, 25 -> да; 25, 5 -> да; 8, 9 -> нет

int c = Convert.ToInt32(Console.ReadLine());
int s = Convert.ToInt32(Console.ReadLine());

if ((c / s == s) || (s / c == c))
    Console.WriteLine($"{c}, {s} -> да");
else
    Console.WriteLine($"{c}, {s} -> нет");