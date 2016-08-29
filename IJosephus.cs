using System;

interface IJosephus
{
    // properties
    int Count { get; }           // total number of soldiers
    int Alive { get; }           // number of alive soldiers
    int LastEliminated { get; }  // last eliminated soldier
    int LastAlive { get; }       // number of surviving soldier
    int PassBy { get; set; }     // "decimatio"

    // methods
    bool EliminateNextSoldier();
    void EliminateAll();
}
