using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject cardPrefab;
    [SerializeField] private Canvas canva;

    [SerializeField] private CardsScriptable cardExample;
    [SerializeField] private SpiritScriptable spiritExample;

    // Start is called before the first frame update
    void Start()
    {
        DrawCardUI(Vector3.one, cardExample, spiritExample);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public GameObject DrawCardUI(Vector3 pos, CardsScriptable card, SpiritScriptable spirit = null)
    {
        GameObject cardUI = Instantiate(cardPrefab, pos, Quaternion.identity, canva.transform);
        cardUI.GetComponent<CardUI>().card = card;
        cardUI.GetComponent<CardUI>().card.spirit = spirit;

        return cardUI;
    }
}
