using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDatabaseDictionary : MonoBehaviour
{
    [SerializeField]
    DatabaseDictionary m_cardDatabaseDictionary;
    public IDictionary<string, CardsScriptable> CardDatabaseDictionary
    {
        get { return m_cardDatabaseDictionary; }
        set { m_cardDatabaseDictionary.CopyFrom(value); }
    }

    [SerializeField]
    public SpiritDictionary spiritDictionary;

    [SerializeField]
    public EnemyDictionary enemyDictionary;

    /*
    [SerializeField]
    DatabaseDictionary m_spiritDatabaseDictionary;
    public IDictionary<string, SpiritScriptable> SpiritDatabaseDictionary
    {
        get { return m_spiritDatabaseDictionary; }
        set { m_spiritDatabaseDictionary.CopyFrom(value); }
    }

    [SerializeField]
    DatabaseDictionary m_enemyDatabaseDictionary;
    public IDictionary<string, EnemyScriptable> EnemyDatabaseDictionary
    {
        get { return m_enemyDatabaseDictionary; }
        set { m_enemyDatabaseDictionary.CopyFrom(value); }
    }
    */
}
