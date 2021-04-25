using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zones : MonoBehaviour
{
    [SerializeField] private List<GameObject> _bounds;
    [SerializeField] private List<LocationEnemyList> _locationsEnemyes;

    private void OnEnable()
    {
        _locationsEnemyes = new List<LocationEnemyList>();
    }

    public int GetLocation(Transform transform)
    {
        if (_bounds[0].transform.position.x > transform.position.x) return 0;

        if (_bounds[_bounds.Count - 1].transform.position.x < transform.position.x) return _bounds.Count;

        for (int i = 0; i < _bounds.Count; i++)
            if (_bounds[i].transform.position.x < transform.position.x && _bounds[i + 1].transform.position.x > transform.position.x) return i + 1;

        Debug.Log("err Zone was not found");
        return -1;
    }

    public List<GameObject> GetLocationEnemys(Transform transform)
    {
        int locationIndex = GetLocation(transform);
        return _locationsEnemyes[locationIndex].Enemys;
    }
}
