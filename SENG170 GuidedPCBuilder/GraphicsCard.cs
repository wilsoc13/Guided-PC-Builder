using System;

public class GraphicsCard : Component
{
    string chipset;
    string gpu;
    int memorySize;

    public GraphicsCard(double price, string chipset, string gpu, int memorySize) : base(price)
    {
        this.chipset = chipset;
        this.gpu = gpu;
        this.memorySize = memorySize;
    }

    public string Chipset
    {
        set { this.chipset = value; }
        get { return chipset; }
    }

    public string GPU
    {
        set { this.gpu = value; }
        get { return gpu; }
    }

    public int MemorySize
    {
        set { this.memorySize = value; }
        get { return memorySize; }
    }
}
