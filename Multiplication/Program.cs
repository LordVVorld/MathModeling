int M = 1000, a = 37, b = 1, N = 1, x = 1;
double u;
while (N <= 100)
{
    x = (a * x + b) % M;
    u = Convert.ToDouble(x) / Convert.ToDouble(M);
    Console.WriteLine("x{0}: {1}, u{2}: {3}", N, x, N, u);
    ++N;
}