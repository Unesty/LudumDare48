using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    Rect hw_size = new Rect(0,0,100,100);
    public bool pr=false;
    public void hw() {
        pr=true ^ pr;
    }
    void OnGUI()
    {
        if(pr) GUI.Label(hw_size ,"Hello World!");
    }
}
