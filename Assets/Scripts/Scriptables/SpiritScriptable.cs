using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

[CreateAssetMenu(fileName = "New Spirit", menuName = "Spirit")]
public class SpiritScriptable : ScriptableObject
{
    public string spiritName;

    [TextArea(1, 5)]
    public string effectDes;

    public CardElement spiritElement;

    public SpiritEffectTypes spiritEffect;

    public Sprite elementIcon;
    public Sprite elementFrame;

}
