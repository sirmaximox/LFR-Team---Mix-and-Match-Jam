using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

   [SerializeField] private HPBar HpBar;


    //Prefab de carta armado por el scriptableObject de carta;
    [SerializeField] private GameObject cardPrefab;

    //Canvas donde se dibuja el UI;
    [SerializeField] private Canvas canvas;

    //Elementos de prueba para dibujar cartas;
    [SerializeField] private CardsScriptable cardExample;
    [SerializeField] private SpiritScriptable spiritExample;

    //prefab de enemigo aramado por el scriptableObject de enemigo;
    [SerializeField] private GameObject enemyPrefab;

    //Canvas donde se dibujan los enemigos;
    [SerializeField] private Canvas enemyCanvas;

    //Elementos de prueba para dibujar enemigos;
    [SerializeField] private EnemyScriptable test_enemy1;
    [SerializeField] private EnemyScriptable test_enemy2;
    [SerializeField] private EnemyScriptable test_enemy3;
    [SerializeField] private EnemyScriptable test_enemyBoss;

    [SerializeField] private Image[] enemyHealthBar;
    
    [SerializeField] private Text deckText;
    
    void Start()
    {
        //Demo para poder invocar enemigos/cartas;
        //DrawCardUI(Vector3.one, cardExample, spiritExample);
        DrawEnemyUI(enemyCanvas, new Vector2(700, 130), test_enemy1);
        DrawEnemyUI(enemyCanvas, new Vector2(260, 130), test_enemy2);
        DrawEnemyUI(enemyCanvas, new Vector2(-200, 130), test_enemy3);
        deckCountUpdate(1);
    }

    private void Update()
    {
        //Test para verificar que el conteo de cartas se actualiza segun la cantidad de elementos de la lista;
       
    }

    /// <summary>
    /// Funcion para dibujar una carta en el UI en base a la carta espiritu y posicion que les pasas
    /// </summary>
    public GameObject DrawCardUI(Vector2 canvasPos, CardsScriptable card, SpiritScriptable spirit = null)
    {
        GameObject cardUI = Instantiate(cardPrefab, canvasPos, Quaternion.identity, canvas.transform);
        cardUI.GetComponent<CardUI>().card = card;
        cardUI.GetComponent<CardUI>().spirit = spirit;
        cardUI.GetComponent<RectTransform>().anchoredPosition = canvasPos;

        return cardUI;
    }

    /// <summary>
    /// Funcion para dibujar un enemigo en el UI en base al objeto de enemigo y la posición que se pasa
    /// </summary>
    public GameObject DrawEnemyUI(Canvas enemyCanvas1, Vector2 canvasPos, EnemyScriptable monster)
    {

        GameObject enemyUI = Instantiate(enemyPrefab, canvasPos, Quaternion.identity, enemyCanvas1.transform);
        enemyUI.GetComponent<EnemyUI>().enemy = monster;
        enemyUI.GetComponent<EnemyUI>().enemyElement.sprite = monster.enemyIcon;
        enemyUI.GetComponent<RectTransform>().anchoredPosition = canvasPos;

        return enemyUI;
    }

    /// <summary>
    /// funcion para actualizar la barra de vida del jugador toma la vida actual, calcula cuanto representa de la vida maxima y modifica la escala del objeto health
    /// </summary>
    public void EnemyHealthUpdate(int enemyID, int maxHealth, int currentHealth)
    {
        
        float hpNormalized = maxHealth/currentHealth;
        enemyHealthBar[enemyID].transform.localScale = new Vector3((float)hpNormalized, 1f);
    }

    public void CaptureEnabler()
    {
        /*Función para activar y desactivar el boton de captura, como definirlo? 
         */
    }

    public void deckCountUpdate(int deckCount)
    {
        deckText.text = deckCount.ToString();

        /*Cada vez que levantas una carta cuenta la cantidad de
         elementos en la lista deckCount y actualiza el texto
         deckNumber que aparece en el mazo para mostrar cuantas 
         cartas quedan*/
    }
    
}
