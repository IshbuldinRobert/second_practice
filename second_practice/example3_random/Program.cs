int x;
for (int num = 1; num <= 10; num++)
{
    x = new Random().Next(1, 9);
    Console.WriteLine($"{num}. {x}");
}