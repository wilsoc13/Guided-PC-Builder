using System;

public class MotherBoard : Component
{
    string socket;
    string memory;
    string formFactor;
    string chipset;

    public MotherBoard(string socket, string memory, string formFactor, string chipset,double price) : base(price)
    {
        this.socket = socket;
        this.memory = memory;
        this.formFactor = formFactor;
        this.chipset = chipset;
    }

    public string Socket
    {
        set { this.socket = value; }
        get { return socket; }
    }

    public string Memory
    {
        set { this.memory = value; }
        get { return memory; }
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
