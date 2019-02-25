using System;

public class RAM : Component
{
    string type;
    int capacity;
    int speed;

    public RAM(string type, int capacity, int speed,double price) : base(price)
    {
        this.type = type;
        this.capacity = capacity;
        this.speed = speed;
    }

    public string Type
    {
        set { this.type = value; }
        get { return type; }
    }

    public int Capacity
    {
        set { this.capacity = value; }
        get { return capacity; }
    }

    public int Speed
    {
        set { this.speed = value; }
        get { return speed; }
    }
}
