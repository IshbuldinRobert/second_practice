// double x = -7;
// double result = Math.Abs(x); // выдает модуль числа
// Console.WriteLine(result);



// double y = 7.123456;
// double res = Math.Round(y, 5); // округляется маьематически
// Console.WriteLine(res);



// double z = 7.923456;
// double r = Math.Floor(z); // отбрасывается дробная часть без матического правила округления
// Console.WriteLine(r);



double x = 7.3;
double y = 7.9;
double z = 3;
double a = 49;
double max = Math.Max(x, y); // выдает максимальное значение
double min = Math.Min(x, y); // выдает минимальное значение
double zz = Math.Pow(z, 3); // возведение в степень
double aa = Math.Sqrt(a); // квадратный корень из числа
Console.WriteLine($"Максимум = {max}, минимум = {min}");
Console.WriteLine($"{z}^3 = {zz}");
Console.WriteLine($"Квадратный корень из {a} = {aa}");