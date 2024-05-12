using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using UnityEngine;
using Zenject;

public class PlayerController : MonoBehaviour
{
    private GarageUIController _garageUIController;
    
    [Inject]
    public void Construct(GarageUIController garageUIController, CamPivotController cameraController)
    {
        _garageUIController = garageUIController;
    }
    private void OnTriggerEnter(Collider other)
    {
        _garageUIController.CallSelectCarBtn(other.transform.GetComponent<CarStand>());
    }

    private void OnTriggerExit(Collider other)
    {
        _garageUIController.SetSelectCarBtnObjActive(false);
    }
}
