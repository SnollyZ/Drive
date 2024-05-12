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
    private GarageUIController _garageUIController;
    private CamPivotController _cameraController;
    private PlayerController _playerController;
    private SceneDataContainer _sceneDataContainer;

    [Inject]
    public void Construct(GarageUIController garageUIController, CamPivotController cameraController, PlayerController playerController, SceneDataContainer sceneDataContainer)
    {
        _garageUIController = garageUIController;
        _cameraController = cameraController;
        _playerController = playerController;
        _sceneDataContainer = sceneDataContainer;
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
        _garageUIController.SetAllUIActive(!isActive);
        _cameraController.gameObject.SetActive(!isActive);
        _playerController.gameObject.SetActive(!isActive);
        cameraObj.SetActive(isActive);
        _sceneDataContainer.SelectedCarType = _type;
    }
}
