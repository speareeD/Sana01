double a, b, c, d;
double x, y, z, r;

Console.WriteLine("Enter a, b, c, d (by enter): ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
d = Convert.ToInt32(Console.ReadLine());

x = (a + 2 * b - c + d) / (c * d);

Console.WriteLine(x);