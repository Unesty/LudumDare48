using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaronController : MonoBehaviour
{
    [SerializeField] private Zones _zones;
    [SerializeField] private int _currentZone;

    private void Update()
    {
        _currentZone = _zones.GetLocation(transform);
    }
}
