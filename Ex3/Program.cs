double Factorial (int n)
{
    if (n == 1)
    {
        // 1! = 1
        // 0! == 1
        return 1;
    }
    else
    {
        return n * Factorial(n - 1);
    }
    
}
for (int i = 1; i < 171; i++)
{
    System.Console.WriteLine(Factorial(i));///1*2*3 = 6
    System.Console.WriteLine($"{i}! = {Factorial(i)}");
}
