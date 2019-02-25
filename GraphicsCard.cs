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
        set { this.chipset = val; }
        get { return chipset; }
    }

    public string GPU
    {
        set { this.gpu = val; }
        get { return gpu; }
    }

    public string MemorySize    
    {
        set { this.memorySize = val; }
        get { return memorySize; }
    }
}
