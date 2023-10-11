using System.Dynamic;
using System.Xml;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public void FinalCode()
    {
        SetToOneOne();
        BiggerNumber();
        ThreeQuarters();
        OneThird();
    }

    private void SetToOneOne()
    {
        _numerator = 1;
        _denominator = 1;
        Console.WriteLine($"{_numerator}/{_denominator}");
        Console.WriteLine(_numerator / _denominator);
    }

    private void BiggerNumber()
    {
        _numerator = 5;
        _denominator = 1;
        Console.WriteLine($"{_numerator}/{_denominator}");
        Console.WriteLine(_numerator / _denominator);
    }

    private void ThreeQuarters()
    {
        _numerator = 3;
        _denominator = 4;
        Console.WriteLine($"{_numerator}/{_denominator}");
        Console.WriteLine((double)_numerator / (double)_denominator);
    }

    private void OneThird()
    {
        _numerator = 1;
        _denominator = 3;
        Console.WriteLine($"{_numerator}/{_denominator}");
        Console.WriteLine((double)_numerator / (double)_denominator);
    }
}