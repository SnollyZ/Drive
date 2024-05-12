using UnityEngine;
using Zenject;

public class CarStandCameraController : MonoBehaviour
{
    [SerializeField] private Transform target;

    private InputService _inputService;
    
    [Inject]
    public void Construct(InputService inputService)
    {
        _inputService = inputService;
    }

    private void Start()
    {
        Move();
        _inputService.OnLeftMouseBtn += Move;
    }

    private void Move()
    {
        transform.LookAt(target);
        transform.RotateAround(target.position, Vector3.up, -Input.GetAxis("Mouse X"));
    }
}
