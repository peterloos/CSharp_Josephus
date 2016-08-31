abstract class Josephus : IJosephus
{
    protected const int DefaultPassBy = 10;  // default "decimatio"

    protected int count;            // total number of soldiers
    protected int alive;            // number of alive soldiers
    protected int lastEliminated;   // last eliminated soldier
    protected int lastAlive;        // number of surviving soldier
    protected int passby;           // "decimatio"

    // c'tor
    public Josephus (int count)
    {
        this.count = count;
        this.alive = this.count;
        this.lastEliminated = 0;
        this.lastAlive = 0;
        this.passby = DefaultPassBy;
    }

    // properties
    public int Count
    {
        get
        {
            return this.count;
        }
    }

    public int Alive
    {
        get
        {
            return this.alive;
        }
    }

    public int LastEliminated
    {
        get
        {
            return this.lastEliminated;
        }
    }

    public int PassBy
    {
        get
        {
            return this.passby;
        }

        set
        {
            this.passby = value;
        }
    }

    public abstract int LastAlive { get; }

    // methods
    abstract public bool EliminateNextSoldier();

    public void EliminateAll()
    {
        while (this.EliminateNextSoldier())
            ;
    }
}