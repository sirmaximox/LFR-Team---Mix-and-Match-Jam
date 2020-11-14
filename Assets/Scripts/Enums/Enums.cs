using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enums
{
    public enum CardElement
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
    public enum CardEffectTypes
    {
        None = 0,
        Slash = 1,
        Ball
    }
    public enum SpiritEffectTypes
    {
        None =0,
        Llama =1,
        HChicken
    }

}