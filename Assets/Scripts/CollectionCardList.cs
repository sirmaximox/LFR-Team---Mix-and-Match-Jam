using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

[System.Serializable]
public class CollectionCardList : MonoBehaviour
{
    public List<CardsScriptable> objectList = new List<CardsScriptable>();
    
    private void Start()
    {
        String[] scriptableObjectArray = System.IO.Directory.GetFiles("Assets/Scripts/Cards");
        String metaExtension = ".meta";
        Match metaMatch;
        foreach (var filename in scriptableObjectArray )
        {
            metaMatch = Regex.Match(filename, metaExtension);
            if (!metaMatch.Success)
            {
                CardsScriptable crd = AssetDatabase.LoadAssetAtPath(filename, typeof(CardsScriptable )) as CardsScriptable ;
                objectList.Add(crd);
            }
        }

        int elementCount = 1;
        
        foreach (var filename in objectList )
        {
            
            Debug.Log(filename);
        }

    }
}
