using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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


    public GameObject DrawCardUI(Vector2 canvasPos, CardsScriptable card, SpiritScriptable spirit = null)
    {

        GameObject cardUI = Instantiate(cardPrefab, canvasPos, Quaternion.identity, canva.transform);
        cardUI.GetComponent<CardUI>().card = card;
        cardUI.GetComponent<CardUI>().spirit = spirit;
        cardUI.GetComponent<RectTransform>().anchoredPosition = canvasPos;

        return cardUI;
    }
}
