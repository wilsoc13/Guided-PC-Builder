using System;

public class Processor : Component
{
    int cores;
    double frequency;
    string manufacturer;
    string socket;
    string name;

    public Processor(string name, int cores, double frequency, string manufacturer, string socket, double price) : base(price)
    {
        this.name = name;
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
        set { this.frequency = value; }
        get { return frequency; }
    }

    public string Manufacturer
    {
        set { this.manufacturer = value; }
        get { return manufacturer; }
    }

    public string Socket
    {
        set { this.socket = value; }
        get { return socket; }
    }

    public string Name
    {
        set { this.name = value; }
        get { return name; }
    }
}
