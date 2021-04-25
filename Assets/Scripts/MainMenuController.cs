using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private bool _flag;

    private Rect _lablePosition;

    private void OnEnable()
    {
        _lablePosition = new Rect(0, 0, 100, 100);
    }

    public void SayHelloWorld() 
    {
        _flag=true ^ _flag;
    }

    private void OnGUI()
    {
        if(_flag) 
            GUI.Label(_lablePosition ,"Hello World!");
    }
}
