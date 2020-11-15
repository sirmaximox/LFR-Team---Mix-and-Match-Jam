using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class DatabaseDictionary:SerializableDictionary<string, CardsScriptable>{
}

[Serializable]
public class SpiritDictionary:SerializableDictionary<string, SpiritScriptable>{
}

[Serializable]
public class EnemyDictionary:SerializableDictionary<string, EnemyScriptable>{
}