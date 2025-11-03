double a, b, x, m, n;
double z1, z2, y;

Console.WriteLine("Enter a, b, c, d (by enter): ");
a = double.Parse(Console.ReadLine());
b = double.Parse(Console.ReadLine());
x = double.Parse(Console.ReadLine());
m = double.Parse(Console.ReadLine());
n = double.Parse(Console.ReadLine());

z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m*m*m*n) + n*m + m*m - m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
y = 2.4 * Math.Abs((x * x + b) / a) + (a-b)*Math.Pow(Math.Sin(a-b), 2) + Math.Pow(10, -2) * (x-b);

Console.WriteLine($"z1 = {z1}");
Console.WriteLine($"z2 = {z2}");
Console.WriteLine($"y = {y}");