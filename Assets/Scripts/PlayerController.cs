using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using UnityEngine;
using Zenject;

public class PlayerController : MonoBehaviour
{
    private UIController _uiController;
    
    [Inject]
    public void Construct(UIController uiController, CamPivotController cameraController)
    {
        _uiController = uiController;
    }
    private void OnTriggerEnter(Collider other)
    {
        _uiController.CallSelectCarBtn(other.transform.parent.GetComponent<CarStand>());
    }

    private void OnTriggerExit(Collider other)
    {
        _uiController.SetSelectCarBtnObjActive(false);
    }
}
