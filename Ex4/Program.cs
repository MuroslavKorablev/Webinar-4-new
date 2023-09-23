double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return     Fibonacci(n - 1) + Fibonacci(n - 2);
}
// int| max 47 Fibonacci
for (int i = 1; i <  6; i++)
{
    System.Console.WriteLine($"f{i} = {Fibonacci(i)}");
}