double a, b, x, m, n;
double z1, z2, y;

Console.WriteLine("Enter a, b, c, d (by enter): ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
x = Convert.ToInt32(Console.ReadLine());
m = Convert.ToInt32(Console.ReadLine());
n = Convert.ToInt32(Console.ReadLine());

z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m*m*m*n) + n*m + m*m - m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
y = 2.4 * Math.Abs((x * x + b) / a) + (a-b)*Math.Pow(Math.Sin(a-b), 2) + Math.Pow(10, -2) * (x-b);