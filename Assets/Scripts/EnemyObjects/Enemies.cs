using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies
{
    private EnemyScriptable _base;
    private int AP;

    public Enemies(EnemyScriptable pBase, int pAp)
    {
        _base = pBase;
        AP = pAp;
    }

    public int apAvailable
    {
        get { return _base.Ap; }
    }
    
}
