using System;

public class Component
{

    double price;

	public Component(double price)
	{
        this.price = price;
	}
    public double Price
    {
        set { this.price = value; }
        get { return this.price; }
    }
}
