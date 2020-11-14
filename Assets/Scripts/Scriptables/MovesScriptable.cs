using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Enemy/New Move")]

public class MovesScriptable : ScriptableObject
{
    [SerializeField] private string attackName;
    [TextArea] [SerializeField] private string description;
    [SerializeField] private int attack;
    [SerializeField] private int apCost;

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
