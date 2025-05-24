using System;
using System.ComponentModel;

public class Fraction
{



    int _top = 1;
    int _bottom = 1;



    public Fraction(int top, int bttom)
    {
        settop(top);
        setbottom(bttom);

    }

    public Fraction(int wholeNUmber)
    {
        _top = wholeNUmber;
    }

    public int gettop()
    {
        return _top;
    }

    public int getbottom()
    {
        return _bottom;
    }

    private void setbottom(int bttom)
    {
        if (bttom == 0)
        {
            Console.WriteLine("Invailed Denominator number set to 1");
            _bottom = 1;
        }
        else
        {
            _bottom = bttom;
        }

    }

    private void settop(int top)
    {
        _top = top;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }




}