using System;

public class MotherBoard : Component
{
    string socket;
    string RAM;
    string formFactor;
    string chipset;

	public MotherBoard(string socket, string RAM, string formFactor, string chipset) : base(price)
	{
        this.socket = socket;
        this.RAM = RAM;
        this.formFactor = formFactor;
        this.chipset = chipset;
	}

    public string Socket
    {
        set { this.socket = value; }
        get { return socket; }
    }

    public string RAM
    {
        set { this.RAM = value; }
        get { return RAM; }
    }

    public string FormFactor
    {
        set { this.formFactor = value; }
        get { return formFactor; }
    }

    public string Chipset
    {
        set { this.chipset = value; }
        get { return chipset; }
    }
}
