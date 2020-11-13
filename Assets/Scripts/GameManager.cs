using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameState gameState;

    // Start is called before the first frame update
    void Start()
    {
        gameState = GameState.Start;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void ResolveState()
    {
        switch (gameState)
        {
            case GameState.Draw:
                //Robar carta del mazo y agregarla a mi mano
                break;

            case GameState.MyTurn:
                //Esperar a que el jugador juegue una carta o decida pasar
                break;

            case GameState.EnemyTurn:
                //Resolver los ataques del enemigo
                break;


        }
    }
}
