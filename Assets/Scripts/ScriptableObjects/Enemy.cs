using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy SO", menuName = "Enemy SO", order = 52)]
public class Enemy : ScriptableObject
{
    [SerializeField]
    private Texture sptite;
    
    [SerializeField]
    private int damage=1;
    //public
}
