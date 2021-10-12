using System;

public class ComplexNum
{
	private double a, b;

	public ComplexNum(double a,double b)
	{
		this.a = a;
		this.b = b;
	}

	private string getResult(double a, double b)
    {
		string result = "";
		if (b > 0 && a != 0)
		{
			result = $"{a}+{b}i";
		}
		else if (b < 0 && a != 0)
		{
			result = $"{a}{b}i";
		}
		else if (b == 0)
		{
			result = $"{a}";
		}
		else if (a == 0)
		{
			result = $"{b}i";
		}
		return result;
	}

	public string sum(ComplexNum first, ComplexNum second)
    {
		double sum_a = first.a + second.a;
		double sum_b = first.b + second.b;
		string result = getResult(sum_a,sum_b);
		return result;
    }
	public string minus(ComplexNum first, ComplexNum second)
	{
		double minus_a = first.a - second.a;
		double minus_b = first.b - second.b;
		string result = getResult(minus_a,minus_b);
		return result;
	}
	public string delenie(ComplexNum first, ComplexNum second)
	{
		string result = "";
		if ((second.a * second.a + second.b * second.b) != 0)
		{
			double delenie1 = (first.a * second.a + first.b * second.b) / (second.a * second.a + second.b * second.b);
			double delenie2 = (first.b * second.a - first.a * second.b) / (second.a * second.a + second.b * second.b);
			result = getResult(delenie1, delenie2);
		}
		return result;
	}
}
