using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(DatabaseDictionary))]
[CustomPropertyDrawer(typeof(SpiritDictionary))]
[CustomPropertyDrawer(typeof(EnemyDictionary))]
public class JamSerializableDictionaryPropertyDrawer : SerializableDictionaryPropertyDrawer
{
    
}
