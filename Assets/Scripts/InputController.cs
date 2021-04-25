using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void FixedUpdate()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float yDirection = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(xDirection, 0, yDirection);

        transform.Translate(direction * Time.deltaTime * _speed);
    }
}
