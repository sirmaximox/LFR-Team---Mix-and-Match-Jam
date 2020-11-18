using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Deck : MonoBehaviour
{
    [SerializeField]
    private List<FullCard> deck = new List<FullCard>();


    private void Start()
    {
        deck[1] = new FullCard();
    }
}
