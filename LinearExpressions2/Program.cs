double a, b, x, m, n;
double z1, z2, y;

Console.Write("Enter a: ");
a = double.Parse(Console.ReadLine());
Console.Write("Enter b: ");
b = double.Parse(Console.ReadLine());
Console.Write("Enter x: ");
x = double.Parse(Console.ReadLine());
Console.Write("Enter m: ");
m = double.Parse(Console.ReadLine());
Console.Write("Enter n: ");
n = double.Parse(Console.ReadLine());

z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m*m*m*n) + n*m + m*m - m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
y = 2.4 * Math.Abs((x * x + b) / a) + (a-b)*Math.Pow(Math.Sin(a-b), 2) + Math.Pow(10, -2) * (x-b);

Console.WriteLine($"z1 = {z1}");
Console.WriteLine($"z2 = {z2}");
Console.WriteLine($"y = {y}");