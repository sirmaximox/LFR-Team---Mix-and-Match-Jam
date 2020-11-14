using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy")]
public class EnemyScriptable : ScriptableObject
{
    [SerializeField] string enemyName;
    [TextArea] [SerializeField] string descriptor;
    [SerializeField] int health;
    [SerializeField] int ap;

    [SerializeField] Sprite enemyArt;

    [SerializeField] CardElement monsterElement;
}
