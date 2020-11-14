using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

[System.Serializable]
public class CardAttributes : MonoBehaviour
{
    [SerializeField] protected string cardName = "None";
    [SerializeField] protected int apCost = 0;
    [SerializeField] protected CardElement element = CardElement.None;
    [SerializeField] protected int damage = 0;



}
