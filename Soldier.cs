using System;

class Soldier
{
    private int number;

    // c'tor
    public Soldier(int number)
    {
        this.number = number;
        this.Next = null;
    }

    // properties
    public Soldier Next { get; set; }

    public int Number
    {
        get
        {
            return this.number;
        }
    }
}