using System;

class JosephusLinkedListImpl : Josephus
{
    private Soldier root;      // root of soldiers
    private Soldier current;   // current soldier

    // c'tors
    public JosephusLinkedListImpl() : this(41) {}

    public JosephusLinkedListImpl(int count) : base (count)
    {
        this.CreateList();
    }

    // properties
    public override int LastAlive
    {
        get
        {
            return this.root.Number;
        }
    }

    // public interface
    public override bool EliminateNextSoldier()
    {
        // more than one soldier?
        if (this.alive == 1)
            return false;

        // locate soldier
        for (int i = 0; i < this.passby - 1; i++)
            this.current = this.current.Next;

        // remove soldier from list
        Soldier node = this.current.Next;
        this.current.Next = node.Next;

        // take care, if root object is removed
        if (this.root == node)
            this.root = this.root.Next;

        this.alive --;
        this.lastEliminated = node.Number;

        return true;
    }

    // overrides
    public override String ToString()
    {
        String s = "[";
        Soldier tmp = root;

        do
        {
            s += String.Format("{0}", tmp.Number);
            if (tmp.Next != root)
                s += ",";
            tmp = tmp.Next;
        }
        while (tmp != root);
        s += "]";

        return s;
    }

    // private helper methods
    private void CreateList()
    {
        // create first soldier
        this.root = new Soldier(1);
        Soldier tmp = this.root;

        // create remaining soldiers
        for (int i = 1; i < count; i++)
        {
            Soldier s = new Soldier(i + 1);

            // link previous soldier with current one
            tmp.Next = s;
            tmp = s;
        }

        // link last soldier with first one
        tmp.Next = this.root;

        // initialize enumeration reference
        this.current = tmp;
    }
}
