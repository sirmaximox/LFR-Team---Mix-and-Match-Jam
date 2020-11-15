using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase: MonoBehaviour
{
    public List<CardsScriptable> cardList;
    public List<SpiritScriptable> spiritList;
    public List<EnemyScriptable> enemyList;
    public Dictionary<string, CardsScriptable> cardDictionary;

    private static CardDatabase _instance;
    public static CardDatabase Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.Log("Card Database not found.");
            }

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;

    }


}
