using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharonStateSwitcher : MonoBehaviour
{
    [SerializeField] private DialogPlayer _dialogPlayer;
    [SerializeField] private Animator _charon;

    private void OnEnable()
    {
        _dialogPlayer.DialogStarting += Stop;   
        _dialogPlayer.DialogEnded += Swim;   
    }

    private void OnDisable()
    {
        _dialogPlayer.DialogStarting -= Stop;
        _dialogPlayer.DialogEnded -= Swim;
    }

    private void Swim()
    {
        _charon.SetTrigger("Going");   
    }

    private void Stop()
    {
        _charon.SetTrigger("Stoped");
    }
}
