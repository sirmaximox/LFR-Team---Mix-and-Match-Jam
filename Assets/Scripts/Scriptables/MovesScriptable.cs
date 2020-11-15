using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Enemy/New Move")]

public class MovesScriptable : ScriptableObject
{
    [SerializeField] public string attackName;
    [TextArea] [SerializeField] public string description;
    [SerializeField] public int attack;
    [SerializeField] public int apCost;

    public string Name
    {
        get { return attackName; }
    }
    
    public string Description
    {
        get { return description; }
    }
    
    public int Attack 
    {
        get { return attack; }
    }
    public int ApCost
    {
        get { return apCost; }
    }

}
