using System;

public class HardDrive : Component
{
    int capacity;
    string driveType;

    public HardDrive(int capacity, string driveType, double price) : base(price)
    {
        this.capacity = capacity;
        this.driveType = driveType;
    }

    public int Capacity
    {
        set { this.capacity = value; }
        get { return capacity; }
    }

    public string DriveType
    {
        set { this.driveType = value; }
        get { return driveType; }
    }
}
