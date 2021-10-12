using System;

public class ComplexNum
{
	private double a, b;

	public ComplexNum(double a,double b)
	{
		this.a = a;
		this.b = b;
	}

	public string sum(ComplexNum first, ComplexNum second)
    {
		double sum_a = first.a + second.a;
		double sum_b = first.b + second.b;
		string result = "";
		if (sum_b > 0 && sum_a!=0)
		{
		    result = $"{sum_a}+{sum_b}i";
		}
		else if (sum_b<0 && sum_a != 0)
        {
			result = $"{sum_a}{sum_b}i";
		}
		else if (sum_b==0)
        {
		    result = $"{sum_a}";
		}
		else if (sum_a==0)
        {
			result = $"{sum_b}i";
		}
		return result;
    }
	public string minus(ComplexNum first, ComplexNum second)
	{
		double minus_a = first.a - second.a;
		double minus_b = first.b - second.b;
		string result = "";
		if (minus_b > 0 && minus_a != 0)
		{
			result = $"{minus_a}+{minus_b}i";
		}
		else if (minus_b < 0 && minus_a != 0)
		{
			result = $"{minus_a}{minus_b}i";
		}
		else if (minus_b == 0)
		{
			result = $"{minus_a}";
		}
		else if (minus_a == 0)
		{
			result = $"{minus_b}i";
		}
		return result;
	}
}
