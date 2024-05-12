using System;
using UnityEngine;

public class InputService : MonoBehaviour
{
    public event Action OnLeftMouseBtn;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            OnLeftMouseBtn?.Invoke();
        }
    }
}
