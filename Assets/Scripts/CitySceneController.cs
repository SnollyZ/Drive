using System.Collections;
using System.Collections.Generic;
using DataBases;
using UnityEngine;
using Zenject;

public class CitySceneController : MonoBehaviour
{
    [SerializeField] private Transform carSpawnPoint;
    [SerializeField] private CarsData carsData;
    private GameObject _carPref;
    
    [Inject]
    public void Construct(SceneDataContainer sceneDataContainer)
    {
        _carPref = carsData.GetCarInfoByType(sceneDataContainer.SelectedCarType).CarPref;
    }
    
    void Start()
    {
        SpawnCar();
    }

    private void SpawnCar()
    {
        Instantiate(_carPref, carSpawnPoint.position, Quaternion.identity);
    }
}
