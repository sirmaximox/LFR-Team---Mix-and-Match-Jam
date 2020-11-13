using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

[System.Serializable]
public class CardAttributes : MonoBehaviour
{
    [SerializeField] protected string cardName = "None";
    [SerializeField] protected int apCost = 0;
    [SerializeField] protected CardType element = CardType.None;
    [SerializeField] protected int damage = 0;



}
