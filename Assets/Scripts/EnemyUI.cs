using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyUI : MonoBehaviour
{
    public EnemyScriptable enemy;
    public SpiritScriptable spirit;
    public Text enemyName;
    
    
    public Image enemyElement;
    public Image enemyArt;

    public Image[] enemyAP = new Image[6];


    void Start()
    {
        DrawEnemyUI();
    }

    void DrawEnemyUI()
    {
        enemyName.text = enemy.enemyName;
        enemyElement.sprite = spirit.elementIcon;
        enemyArt.sprite = enemy.enemyArt;

        for ( int i = 0; i < enemy.ap; i++)
        {
            
            enemyAP[i].enabled = true;
        }
    }
}