using System;

class JosephusArrayImpl : Josephus
{
    private bool[] soldiers;   // root of soldiers
    private int current;       // current soldier

    // c'tors
    public JosephusArrayImpl() : this(41)
    {
        this.alive = this.count;
    }

    public JosephusArrayImpl(int count) : base (count)
    {
        this.soldiers = new bool[count];
        for (int i = 0; i < count; i++)
            soldiers[i] = true;

        this.current = 0;
    }

    // properties
    public override int LastAlive
    {
        get
        {
            if (this.lastAlive == 0)
            {
                this.MoveToNextAliveSoldier();
                this.lastAlive = this.current + 1;
            }

            return this.lastAlive;
        }
    }

    // public interface
    public override bool EliminateNextSoldier()
    {
        // more than one soldier?
        if (this.alive == 1)
            return false;

        for (int i = 0; i < this.passby - 1; i++)
        {
            this.MoveToNextAliveSoldier();

            // skip found alive soldier
            this.MoveToNext();
        }

        this.MoveToNextAliveSoldier();

        // eliminate 'n'.th soldier
        this.soldiers[this.current] = false;
        this.alive--;
        this.lastEliminated = this.current + 1;

        return true;
    }

    // overrides
    public override String ToString()
    {
        String s = "[";

        int save = this.current;  // save current state of position index
        this.current = 0;

        int count = 0;
        do
        {
            this.MoveToNextAliveSoldier();
            s += String.Format("{0}", this.current + 1);

            count++;
            if (count < this.Alive)
                s += String.Format (",");
            this.MoveToNext();
        }
        while (count < this.Alive);
        s += ']';

        this.current = save;  // restore current state of position index

        return s;
    }

    // private helper methods
    private void MoveToNextAliveSoldier()
    {
        while (this.soldiers[current] == false)
        {
            // move index to next entry
            this.MoveToNext();
        }
    }

    private void MoveToNext()
    {
        // move index to next entry
        this.current++;
        if (this.current >= this.count)
            this.current = 0;
    }
}
