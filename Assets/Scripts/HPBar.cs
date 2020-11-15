using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBar : MonoBehaviour
{
    [SerializeField] private GameObject health;

    public void SetHP(int hpNormalized)
    {
        health.transform.localScale = new Vector3((float)hpNormalized, 1f);
    }
}
