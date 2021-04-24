using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaronController : MonoBehaviour
{
    public Zones ZB;
    public int current_zone;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        current_zone = ZB.GetLocation(transform);
        
    }
}
