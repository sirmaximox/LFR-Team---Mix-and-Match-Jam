using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardUI : MonoBehaviour
{
    public CardsScriptable card;
    public SpiritScriptable spirit;

    public Text cardName;
    public Text cardDes;
    public Text cardDamage;

    public Image cardElement;
    public Image cardArt;
    public Image cardFrame;

    public Image[] cardCost = new Image[6];


    void Start()
    {
        DrawCardUI();
    }

    void DrawCardUI()
    {
        cardName.text = card.cardName;
        cardDamage.text = card.cardDamage.ToString();
               
        cardArt.sprite = card.cardArt;

        cardDes.text = card.cardDes;

        
        for ( int i = 0; i < card.cardCost; i++)
        {
            
            cardCost[i].enabled = true;
        }

        if (spirit != null)
        {
            cardElement.sprite = spirit.elementIcon;
            cardFrame.sprite = spirit.elementFrame;
            cardDes.text += spirit.effectDes;
        }
        else
        {
            cardDes.text += card.extraDes;
        }
    }
}
