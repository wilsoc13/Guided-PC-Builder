using System;

public class PowerSupply : Component
{
    int wattage;

    public PowerSupply(int wattage,double price) : base(price)
    {
        this.wattage = wattage;
    }

    public int Wattage
    {
        set { this.wattage = value; }
        get { return wattage; }
    }
}
