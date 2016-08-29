using System;

class Soldier
{
    private int number;
    private Soldier next;

    public Soldier(int number)
    {
        this.number = number;
        this.next = null;
    }

    public Soldier(Soldier next, int number)
    {
        this.number = number;

        // link this soldier with another one
        this.next = next;
    }

    // properties

    // TODO: ????????????? Referenzen sollten immer private sien !!!!!!!
    public Soldier Next
    {
        set
        {
            this.next = value;
        }

        get
        {
            return this.next;
        }
    }

    public int Number
    {
        get
        {
            return this.number;
        }
    }
}