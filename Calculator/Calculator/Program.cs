
var calc = new Calculator.Calculator();
double a = 8;
double b = 16;

Console.WriteLine(calc.Sum(a, b));
Console.WriteLine(calc.Substract(a, b));
Console.WriteLine(calc.Multiply(a, b));
Console.WriteLine(calc.Divide(a, b));
Console.WriteLine(calc.Sqrt(a));

try
{
    Console.WriteLine(calc.Divide(a, 0));
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}

try 
{
    Console.WriteLine(calc.Sqrt(-5));
}
catch(Exception ex)
{
    Console.WriteLine(ex.ToString());
}
