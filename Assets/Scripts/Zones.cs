using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zones : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> bounds;
    
    [System.Serializable]
    public class le_class
    {
        public List<GameObject> enemys;
    }
    public List<le_class> location = new List<le_class>();
    
    public int GetLocation(Transform tr)
    {
        if(bounds[0].transform.position[0]<tr.position[0]) return 0;
        if(bounds[bounds.Count].transform.position[0]>tr.position[0]) return bounds.Count;
        for(int i=0; i<bounds.Count;i++) {
            if(bounds[i].transform.position[0]<tr.position[0] && bounds[i+1].transform.position[0]>tr.position[0]) return i;
        }
        return -1;
    }
    
    public List<GameObject> GetLocationEnemys(Transform tr)
    {
        int l = GetLocation(tr);
        return location[l].enemys;
    }
}
