using System;
using System.Collections.Generic;
using System.Text;

public class Sphere
{
	private double diameter;
	public Sphere()
	{
		diameter = 2.0;
	}

	public Sphere(double diameter)
	{
		this.setDiameter(diameter);
	}

	public double getVolume()
	{
		return (4.0 / 3.0) * Math.PI * Math.Pow(diameter/2, 3);
	}

	public double getSurfaceArea()
	{
		return 4.0 * Math.PI * Math.Pow(diameter/2, 2);
	}

	public double getDiameter()
	{
		return diameter;
	}

	public void setDiameter(double diameter)
	{
		if (diameter < 2)
			this.diameter = 2;
		else
			this.diameter = diameter;
	}

	public override String ToString()
	{
		return "Sphere [diameter=" + diameter + "]";
	}
}