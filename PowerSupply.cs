using System;

public class PowerSupply : Component
{
    int wattage;

	public PowerSupply(int wattage) : base (price)
	{
        this.wattage = wattage;
	}

    public int Wattage
    {
        set { this.wattage = wattage; }
        get { return wattage; }
    }
}
