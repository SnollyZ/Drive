using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject selectCarBtnObj;
    [SerializeField] private GameObject backBtnObj;
    [SerializeField] private GameObject startBtnObj;
    [SerializeField] private GameManagerAndUI gameManagerAndUI;
    private CarStand _currentCarStand;

    public void CallSelectCarBtn(CarStand currentCarStand)
    {
        selectCarBtnObj.SetActive(true);
        _currentCarStand = currentCarStand;
    }
    public void SetSelectCarBtnObjActive(bool isActive)
    {
        selectCarBtnObj.SetActive(isActive);
    }
    
    public void SelectCarBtnOnClick()
    {
        _currentCarStand.SetCameraOnStandActive(true);
        SetBackBtnActive(true);
        StartBtnActive(true);
        SetSelectCarBtnObjActive(false);
    }

    public void SetAllUIActive(bool isActive)
    {
        gameManagerAndUI.All_UI.SetActive(isActive);
    }

    private void SetBackBtnActive(bool isActive)
    {
        backBtnObj.SetActive(isActive);
    }
    
    private void StartBtnActive(bool isActive)
    {
        startBtnObj.SetActive(isActive);
    }

    public void BackBtnOnClick()
    {
        SetBackBtnActive(false);
        StartBtnActive(false);
        _currentCarStand.SetCameraOnStandActive(false);
    }

    public void StartBtnOnClick()
    {
        
    }
}
