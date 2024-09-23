using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    public static EffectManager instance;
    public GameObject[] fruitsEffects;
    public GameObject logEffect;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}
