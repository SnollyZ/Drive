using UnityEngine;
using Zenject;

public class CityUIController : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreenObj;
    
    private SceneLoader _sceneLoader;

    [Inject]
    public void Construct(SceneLoader sceneLoader)
    {
        _sceneLoader = sceneLoader;
    }
    
    public void CallGameOverScreen()
    {
        gameOverScreenObj.SetActive(true);
    }

    public void BackBtnOnClick()
    {
        _sceneLoader.LoadSceneByIndex(0);
    }
}
