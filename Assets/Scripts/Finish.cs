using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Finish : MonoBehaviour
{
    [SerializeField]private CityUIController cityUIController;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cityUIController.CallGameOverScreen();
        }
    }
}
