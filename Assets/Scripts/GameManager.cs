using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameState gameState;

    private bool _dirtyFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        gameState = GameState.Start;
    }

    // Update is called once per frame
    void Update()
    {
        
        if ( NeedsUpdate() )
        {
            ResolveState();
        }
        
    }


    private void ResolveState()
    {
        switch (gameState)
        {
            case GameState.Draw:
                //Robar carta del mazo y agregarla a mi mano
                /*
                 * Check Deck.list and pull first (or last) item.
                 * Get Hand reference and add the Card item.
                 * Check for any effect?
                 */

                // Break not needed here as Draw state is automatically followed by Player's turn state.
                //break;

            case GameState.MyTurn:
                //Esperar a que el jugador juegue una carta o decida pasar

                /*
                 * Get Player instance and refresh ap.
                 */
                break;

            case GameState.EnemyTurn:
                //Resolver los ataques del enemigo
                /*
                 * Get Enemy instances and check for available attacks.
                 * Execute Enemy attacks (random? basic AI?)
                 *
                 * if (EnemyManager.GetPendingEnemyActions() < 1)
                 * {
                 *      EndCurrentTurn();
                 * }
                 */
                break;

        }
    }

    // End the turn and set the game state to the proper one. Also set the update flag to active.
    public void EndCurrentTurn()
    {
        if (gameState == GameState.MyTurn)
        {
            gameState = GameState.EnemyTurn;
        }
        else
        {
            gameState = GameState.Draw;
        }

        SetUpdateRequired();
    }

    // Check if the dirty flag is active and return its value. If the dirty flag is active, it is cleaned before returning the true value.
    private bool NeedsUpdate()
    {
        if (_dirtyFlag)
        {
            _dirtyFlag = false;
            return true;
        }

        return false;
    }

    // Marks the dirty flag as active for the Update method to run any code necessary.
    private void SetUpdateRequired()
    {
        _dirtyFlag = true;
    }
}
