using UnityEngine;
using Zenject;

public class GarageUIController : MonoBehaviour
{
    [SerializeField] private GameObject selectCarBtnObj;
    [SerializeField] private GameObject backBtnObj;
    [SerializeField] private GameObject startBtnObj;
    [SerializeField] private GameManagerAndUI gameManagerAndUI;
    
    private CarStand _currentCarStand;
    private SceneLoader _sceneLoader;

    [Inject]
    public void Construct(SceneLoader sceneLoader)
    {
        _sceneLoader = sceneLoader;
    }

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
        _sceneLoader.LoadSceneByIndex(1);
    }
}
