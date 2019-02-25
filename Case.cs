using System;

public class Case : Component
{
    string moboMount;

	public Case(string moboMount, double price) : base (price)
	{
        this.moboMount = moboMount;
	}
    public string MoboMount
    {
        set { this.moboMount = value; }
        get { return moboMount; }
    }
}
