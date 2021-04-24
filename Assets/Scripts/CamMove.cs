using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public Transform follow;
    Vector3 offset;
    void Start()
    {
        offset = transform.position-follow.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = offset+follow.position;
    }
}
