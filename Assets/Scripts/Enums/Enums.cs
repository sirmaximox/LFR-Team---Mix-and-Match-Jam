using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enums
{
    public enum CardType
    {
        None = 0,
        Fuego = 1,
        Bosque,
        Tierra,
        Electricidad,
        Agua
    }

    public enum GameState
    {
        None = 0,
        Start = 1,
        Draw,
        MyTurn,
        EnemyTurn
    }

}