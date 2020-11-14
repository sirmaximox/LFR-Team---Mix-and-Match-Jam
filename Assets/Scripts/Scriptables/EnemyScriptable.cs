using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

[CreateAssetMenu(fileName = "Enemy", menuName = "Enemy/New Enemy")]
public class EnemyScriptable : ScriptableObject
{
    [SerializeField] public string enemyName;
    [TextArea] [SerializeField] public string descriptor;
    [SerializeField] public int health;
    [SerializeField] public int ap;

    [SerializeField] public Sprite enemyArt;

    [SerializeField] public CardElement monsterElement;

    [SerializeField] public List<AvailableMove> availableMove;
    
    public string Name
    {
        get { return enemyName; }
    }
    
    public string Description
    {
        get { return descriptor; }
    }
    
    public int Health 
    {
        get { return health; }
    }
    public int Ap
    {
        get { return ap; }
    }

    public Sprite EnemyArt
    {
        get { return enemyArt; }
    }

    public List<AvailableMove> AvailableMoves
    {
        get { return AvailableMoves; }

    }

    [System.Serializable]
    public class AvailableMove
    {
        [SerializeField] private MovesScriptable movesBase;
        
        public MovesScriptable Base
        {
            get { return movesBase; }
        }

    }

}
