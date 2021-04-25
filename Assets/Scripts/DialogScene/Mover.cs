using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _currentSpeed;

    private void OnEnable()
    {
        Go();
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.right * Time.deltaTime * _currentSpeed);
    }

    public void Go()
    {
        _currentSpeed = _speed;
    }

    public void Stop()
    {
        _currentSpeed = 0;
    }
}
