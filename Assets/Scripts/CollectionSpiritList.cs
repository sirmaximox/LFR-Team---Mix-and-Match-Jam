using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

[System.Serializable]
public class CollectionSpiritList : MonoBehaviour
{
    public List<SpiritScriptable> spiritList = new List<SpiritScriptable>();
    
    private void Start()
    {
        String[] scriptableObjectArray = System.IO.Directory.GetFiles("Assets/Scripts/SpiritS");
        String metaExtension = ".meta";
        Match metaMatch;
        foreach (var filename in scriptableObjectArray )
        {
            metaMatch = Regex.Match(filename, metaExtension);
            if (!metaMatch.Success)
            {
                SpiritScriptable crd = AssetDatabase.LoadAssetAtPath(filename, typeof(SpiritScriptable )) as SpiritScriptable ;
                spiritList.Add(crd);
            }
        }

        foreach (var filename in spiritList )
        {
            Debug.Log(filename);
        }

    }
}