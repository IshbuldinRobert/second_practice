// напишите программу котрая выводит случайное число из отрезка [10, 99] и показываеи наибольшую цифру
// например 78 -> 8

int x = new Random().Next(10, 100);

int x1 = x / 10;
int x2 = x % 10;

if(x1 > x2) Console.WriteLine($"{x} -> {x1}");
else if (x1 < x2) Console.WriteLine($"{x} -> {x2}");
else Console.WriteLine($"В числе {x} две одинаковых цифры, нет смысла сравнивать");