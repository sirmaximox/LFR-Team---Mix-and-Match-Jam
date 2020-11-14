﻿using System.Collections;
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

    public Sprite cardSprite;
    public Sprite cardElementSprite;
    public Sprite cardArt;
    public Sprite Stars;

    public CardEffectTypes effectId;

    public CardEffectTypes[] effect;
        
}
