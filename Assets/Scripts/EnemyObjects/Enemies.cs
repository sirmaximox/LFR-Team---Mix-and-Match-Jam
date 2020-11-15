using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies
{
    public EnemyScriptable Base;
    public int AP;
    public List<Moves>Move { get; set; }

    public int HealthPoints { get; set; }
    public Enemies(EnemyScriptable pBase, int pAp)
    {
        Base = pBase;
        AP = pAp;
        HealthPoints = maxHealth;
        Move = new List<Moves>();
        /*foreach (var move in Base.availableMove)
        {
            
        }*/
    }


    public int apAvailable
    {
        get { return Base.Ap; }
    }

    public int maxHealth
    {
        get { return Base.maxHealth; }
    }
    
}
