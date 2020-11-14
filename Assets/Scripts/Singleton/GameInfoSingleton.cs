using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class GameInfoSingleton : MonoBehaviour
{

    public static GameInfoSingleton Instance { get; private set; }

    private int playerLife;
    private CardElement currentPlayerType = CardElement.None;
    //private List<CardInstance> deck = new List<CardInstance>;


    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Player life functions
    public int GetPlayerLife() => playerLife;
    public void ModifyPlayerLife(int mod)
    {
        playerLife += mod;

        //if (playerLife <= 0) GameFlowManager.triggerLose();
    }

    // Player Element functions
    public CardElement GetCurrentPlayerElement() => currentPlayerType;
    public void SetCurrentPlayerElement(CardElement newType) { currentPlayerType = newType; }
}
