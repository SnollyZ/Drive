using System;
using DataBases;
using UnityEngine;

public class SceneDataContainer : MonoBehaviour
{
    [HideInInspector]public CarType SelectedCarType;
    private void Awake()
    {
        //DontDestroyOnLoad(gameObject);
    }

    
}
