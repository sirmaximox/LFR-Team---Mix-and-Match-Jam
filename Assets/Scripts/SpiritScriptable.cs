using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

[CreateAssetMenu(fileName = "New Spirit", menuName = "Spirit")]
public class SpiritScriptable : ScriptableObject
{
    public string spiritName;

    public CardElement spiritElement;

    public SpiritEffectTypes spirtEffect;

}
