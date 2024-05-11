using System;
using System.Collections;
using System.Collections.Generic;
using DataBases;
using UnityEngine;
using Zenject;

public class CarStand : MonoBehaviour
{
    [SerializeField] private CarsData _carsData;
    [SerializeField] private CarType _type;
    [SerializeField] private Transform _carTarget;
    [SerializeField] private GameObject cameraObj;
    

    private CarInfo _carInfo;
    private UIController _uiController;
    private CamPivotController _cameraController;
    private PlayerController _playerController;

    [Inject]
    public void Construct(UIController uiController, CamPivotController cameraController, PlayerController playerController)
    {
        _uiController = uiController;
        _cameraController = cameraController;
        _playerController = playerController;
    }
    private void Start()
    {
        _carInfo = _carsData.GetCarInfoByType(_type);
        SpawnCar();
    }

    private void SpawnCar()
    {
        GameObject newCar = Instantiate(_carInfo.CarPref);
        newCar.transform.position = _carTarget.position;
        newCar.transform.rotation = Quaternion.identity;
        newCar.transform.parent = transform;
    }

    public void SetCameraOnStandActive(bool isActive)
    {
        _uiController.SetAllUIActive(!isActive);
        _cameraController.gameObject.SetActive(!isActive);
        _playerController.gameObject.SetActive(!isActive);
        cameraObj.SetActive(isActive);
    }
}
