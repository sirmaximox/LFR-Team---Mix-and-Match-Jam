using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves

{
    public MovesScriptable Base { get; set; }
    public int ApCost { get; set; }

    public Moves(MovesScriptable pBase, int apCost)
    {
        Base = pBase;
        ApCost = apCost;

    }
}
