using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject cardPrefab;
    [SerializeField] private Canvas canvas;

    [SerializeField] private CardsScriptable cardExample;
    [SerializeField] private SpiritScriptable spiritExample;
    
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Canvas enemyCanvas;
   

    [SerializeField] private EnemyScriptable enemy1;
    [SerializeField] private EnemyScriptable enemy2;
    [SerializeField] private EnemyScriptable enemy3;
    [SerializeField] private EnemyScriptable enemyBoss;


    // Start is called before the first frame update
    void Start()
    {
        DrawCardUI(Vector3.one, cardExample, spiritExample);
        DrawEnemyUI(enemyCanvas, new Vector2(725,130), enemy1);
        DrawEnemyUI(enemyCanvas, new Vector2(350,130), enemy2);
        DrawEnemyUI(enemyCanvas, new Vector2(-30,130), enemy3);
    }


    public GameObject DrawCardUI(Vector2 canvasPos, CardsScriptable card, SpiritScriptable spirit = null)
    {
        GameObject cardUI = Instantiate(cardPrefab, canvasPos, Quaternion.identity, canvas.transform);
        cardUI.GetComponent<CardUI>().card = card;
        cardUI.GetComponent<CardUI>().spirit = spirit;
        cardUI.GetComponent<RectTransform>().anchoredPosition = canvasPos;

        return cardUI;
    }
    
    public GameObject DrawEnemyUI(Canvas enemyCanvas1, Vector2 canvasPos, EnemyScriptable monster)
    {

        GameObject enemyUI = Instantiate(enemyPrefab, canvasPos, Quaternion.identity, enemyCanvas1.transform);
        enemyUI.GetComponent<EnemyUI>().enemy = monster;
        enemyUI.GetComponent<EnemyUI>().enemyElement.sprite = monster.enemyIcon;
        enemyUI.GetComponent<RectTransform>().anchoredPosition = canvasPos;

        return enemyUI;
    }
}
