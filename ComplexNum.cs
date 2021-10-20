using System;

public class ComplexNum
{
	private double a, b;

	public ComplexNum(double a, double b)
	{
		this.a = a;
		this.b = b;
	}
    public override bool Equals(object obj)
    {
		bool eq = false;
		if (obj is ComplexNum)
		{
			eq = this.Equals(obj as ComplexNum);
		}
		return eq;
    }
	public bool Equals(ComplexNum first)
	{
		bool eq = false;
		if (first.a == this.a && first.b == this.b)
		{
			eq = true;
		}
		return eq;
	}

	public override string ToString()
    {
		return this.getResult(a, b);
    }

    private string getResult(double a, double b)
	{
		string result = "";
		if (b > 0 && a != 0)
		{
			result = $"{a}+{b} i";
		}
		else if (b < 0 && a != 0)
		{
			result = $"{a}{b} i";
		}
		else if (b == 0)
		{
			result = $"{a}";
		}
		else if (a == 0)
		{
			result = $"{b} i";
		}
		return result;
	}


	public static ComplexNum operator+(ComplexNum first, ComplexNum second)
	{
		double sum_a = first.a + second.a;
		double sum_b = first.b + second.b;
		ComplexNum third = new ComplexNum(sum_a, sum_b);
		return third;
	}

	public static ComplexNum operator-(ComplexNum first, ComplexNum second)
	{
		double minus_a = first.a - second.a;
		double minus_b = first.b - second.b;
		ComplexNum third = new ComplexNum(minus_a, minus_b);
		return third;
	}

	public static ComplexNum operator*(ComplexNum first, ComplexNum second)
	{
		double ymn1 = first.a * second.a - first.b * second.b;
		double ymn2 = first.a * second.b + second.a * first.b;
		ComplexNum third = new ComplexNum(ymn1, ymn2);
		return third;
	}

	public static ComplexNum operator/(ComplexNum first, ComplexNum second)
	{
		ComplexNum third = new ComplexNum(0, 0);
		if ((second.a * second.a + second.b * second.b) != 0)
		{
			double delenie1 = (first.a * second.a + first.b * second.b) / (second.a * second.a + second.b * second.b);
			double delenie2 = (first.b * second.a - first.a * second.b) / (second.a * second.a + second.b * second.b);
			third.a = delenie1;
			third.b = delenie2;
		}
		return third;
	}

	public string Comparison(ComplexNum first, ComplexNum second)
	{
		string result = "";
		double vect1 = Math.Sqrt(first.a * first.a + first.b * first.b);
		double vect2 = Math.Sqrt(second.a * second.a + second.b * second.b);
		if (vect1>vect2)
        {
			result = "Вектор 1-ого числа больше.";
        }
		else if (vect1<vect2)
        {
			result = "Вектор 2-ого числа больше.";
		}
		else if (vect1 == vect2)
        {
			result = "Вектора равны.";
		}
		return result;
	}

}
