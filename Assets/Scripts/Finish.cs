using UnityEngine;

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
