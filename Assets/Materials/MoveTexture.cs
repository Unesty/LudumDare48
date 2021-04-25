using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTexture : MonoBehaviour
{
    // Scroll main texture based on time
    // Or follow object

    [SerializeField]
    Vector2 _scrollSpeed;
    Renderer _rend;
    [SerializeField]
    Transform _follow;

    void Start()
    {
        _rend = GetComponent<Renderer> ();
    }

    void Update()
    {
        //_rend.material.mainTextureOffset = new Vector2(Time.time*_scrollSpeed[0],Time.time*_scrollSpeed[1]);
        _rend.material.mainTextureOffset = new Vector2(_follow.position[0]*_scrollSpeed[0],_follow.position[1]*_scrollSpeed[1]);
    }
}
