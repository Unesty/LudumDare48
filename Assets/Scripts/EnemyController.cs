using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    List<GameObject> enemys;
    [SerializeField]
    uint state;
    [SerializeField]
    float time;
    [SerializeField]
    float timer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(state) {
            case 0: {
                break;
            }
            case 1: {
                break;
            }
        }
    }
}
