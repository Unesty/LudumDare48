using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Map Zones SO", menuName = "Map Zones SO", order = 52)]
public class MapZones : ScriptableObject
{
    [SerializeField]
    List<GameObject> bounds;
    
    [SerializeField]
    List<List<GameObject>> location_enemys;
    
}
