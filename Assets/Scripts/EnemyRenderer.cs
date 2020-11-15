using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyRenderer : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab1;
    [SerializeField] private GameObject enemyPrefab2;
    [SerializeField] private GameObject enemyPrefab3;
    [SerializeField] private Canvas enemyCanvas1;
    [SerializeField] private Canvas enemyCanvas2;
    [SerializeField] private Canvas enemyCanvas3;

    [SerializeField] private EnemyScriptable enemyExample1;
    [SerializeField] private EnemyScriptable enemyExample2;
    [SerializeField] private EnemyScriptable enemyExample3;


    void Start()
    {
        DrawEnemyUI1(enemyCanvas1, Vector3.one, enemyExample1);
        DrawEnemyUI1(enemyCanvas2, Vector3.one, enemyExample2);
        DrawEnemyUI1(enemyCanvas3, Vector3.one, enemyExample3);
    }

    public GameObject DrawEnemyUI1(Canvas enemyCanvas1, Vector2 canvasPos, EnemyScriptable monster)
    {

        GameObject enemyUI = Instantiate(enemyPrefab1, canvasPos, Quaternion.identity, enemyCanvas1.transform);
        enemyUI.GetComponent<EnemyUI>().enemy = monster;
        enemyUI.GetComponent<EnemyUI>().enemyElement.sprite = monster.enemyIcon;
        enemyUI.GetComponent<RectTransform>().anchoredPosition = canvasPos;

        return enemyUI;
    }
    
    public GameObject DrawEnemyUI2(Canvas enemyCanvas2, Vector2 canvasPos, EnemyScriptable monster)
    {

        GameObject enemyUI = Instantiate(enemyPrefab2, canvasPos, Quaternion.identity, enemyCanvas2.transform);
        enemyUI.GetComponent<EnemyUI>().enemy = monster;
        enemyUI.GetComponent<RectTransform>().anchoredPosition = canvasPos;

        return enemyUI;
    }
    
    public GameObject DrawEnemyUI3(Canvas enemyCanvas3, Vector2 canvasPos, EnemyScriptable monster)
    {

        GameObject enemyUI = Instantiate(enemyPrefab3, canvasPos, Quaternion.identity, enemyCanvas3.transform);
        enemyUI.GetComponent<EnemyUI>().enemy = monster;
        enemyUI.GetComponent<RectTransform>().anchoredPosition = canvasPos;

        return enemyUI;
    }
    
}