using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyRenderer : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab1;
    [SerializeField] private Canvas enemyCanvas;
   

    [SerializeField] private EnemyScriptable enemyExample1;
    [SerializeField] private EnemyScriptable enemyExample2;
    [SerializeField] private EnemyScriptable enemyExample3;


    void Start()
    {
        DrawEnemyUI(enemyCanvas, new Vector2(0,0), enemyExample1);
        DrawEnemyUI(enemyCanvas, new Vector2(60,0), enemyExample2);
        DrawEnemyUI(enemyCanvas, new Vector2(680,600), enemyExample3);
    }

    public GameObject DrawEnemyUI(Canvas enemyCanvas1, Vector2 canvasPos, EnemyScriptable monster)
    {

        GameObject enemyUI = Instantiate(enemyPrefab1, canvasPos, Quaternion.identity, enemyCanvas1.transform);
        enemyUI.GetComponent<EnemyUI>().enemy = monster;
        enemyUI.GetComponent<EnemyUI>().enemyElement.sprite = monster.enemyIcon;
        enemyUI.GetComponent<RectTransform>();

        return enemyUI;
    }
}