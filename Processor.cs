using System;

public class Processor : Component
{
    int cores;
    double frequency;
    string manufacturer;
    string socket;

	public Processor(int cores, double frequency, string manufacturer, string socket, double price) : base(price)
	{
        this.cores = cores;
        this.frequency = frequency;
        this.manufacturer = manufacturer;
        this.socket = socket;

	}

    public int Cores
    {
        set { this.cores = value; }
        get { return cores; }
    }

    public double Frequency
    {
        set { this.cores = value; }
        get { return cores; }
    }

    public string Manufacturer
    {
        set { this.manufacturer = value; }
        get { return manufacturer; }
    }

    public double Socket
    {
        set { this.socket = value; }
        get { return socket; }
    }
}
