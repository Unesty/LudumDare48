using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private uint _state;
    [SerializeField] private float _time;
    [SerializeField] private float _timer;

    private List<GameObject> _enemys;

    private void Update()
    {
        switch (_state)
        {
            case 0:
                break;
            case 1:
                break;
        }
    }
}
