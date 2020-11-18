using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class CardsScriptable : ScriptableObject
{
    public string cardName;

    public int cardCost;
    public int cardDamage;
    public CardElement cardElement;

    [TextArea(1, 5)]
    public string cardDes;
    [TextArea(1, 5)]
    public string extraDes;

    public Sprite cardArt;

    public CardEffectTypes effectId;

    public CardEffectTypes[] effect;

    /*public void Slash()
    {
        BattleManager.playerTarget.hp -= cardDamage;
    }

    public void Whilrwind()
    {
        foreach enemy in BattleManager.Enemy[]
        {
            BattleManager.Enemy[enemy].hp -= cardDamage;
        }
    }

    public void Heal()
    {
        BatteManager.Player.hp += cardDamage;
    }

    public void Splash()
    {
        BattleManager.playerTarget -= cardDamage;
        if ((BattleManager.playerTarget--) > 0)
        {
            BatteManager.Enemy[playerTarget--] -= cardDamage / 2;
        }
        if ((BattleManager.playerTarget++) < 3)
        {
            BatteManager.Enemy[playerTarget++] -= cardDamage / 2;
        }
    }

    public void PotOfGreed()
    {
        BattleManager.GetComponent<Deck>().drawCard;
        BattleManager.GetComponent<Deck>().drawCard;
    }*/


        
}
