namespace Homework_Extensions.Extensions;

public static class DoubleExtensions
{
    public static double ToPercent(double number)
    {
        double n = number * 100;
        return n;
    }

    public static double RoundDown(double number)
    {
        return (int)number;
    }

    public static decimal ToDecimal(double number)
    {
        return (decimal)number;
    }

    public static bool IsGreater(double number, double compareValue)
    {
        return number > compareValue;
    }
    public static bool IsLess(double number, double compareValue)
    {
        return number < compareValue;
    }
}