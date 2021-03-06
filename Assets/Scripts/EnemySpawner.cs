using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> enemys;
    [SerializeField]
    List<GameObject> spawned;
    [SerializeField]
    Transform boat;
    public uint max_enemy_count;
    uint spawned_count;
    [SerializeField]
    Vector2 enemy_off = new Vector2(30,30);
    [SerializeField]
    float max_distance = 50f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(spawned.Count<max_enemy_count){
        if(Random.Range(0,100)<3) {
            GameObject instanced = Instantiate(enemys[Random.Range(0,enemys.Count)],transform.position + new Vector3(Random.Range(-enemy_off[0],enemy_off[1]),0,Random.Range(-enemy_off[0],enemy_off[1])), Quaternion.identity);
            spawned.Add(instanced);
            spawned_count++;
        }
        }
        DeleteFarObjects();
    }
    
    void DeleteFarObjects()
    {
        for(int i=0; i< spawned.Count; i++) {
            if(spawned[i]==null) {
                continue;
            }
            if(Vector3.Distance(transform.position,spawned[i].transform.position)>max_distance)
            {
                Destroy(spawned[i]);
                spawned.Remove(spawned[i]);
            }
        }
    }
}
