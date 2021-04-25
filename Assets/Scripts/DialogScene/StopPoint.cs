using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopPoint : MonoBehaviour
{
    [SerializeField] private DialogTrigger _trigger;
    [SerializeField] private DialogPlayer _dialogPlayer;
    [SerializeField] private Mover _player;

    private void OnEnable()
    {
        _dialogPlayer.DialogEnded +=GoAway;
    }

    private void OnDisable()
    {
        _dialogPlayer.DialogEnded -=GoAway;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Boat>(out Boat boat))
        {
            Stop();
            _trigger.TriggerDialog();
        }
    }

    private void GoAway()
    {
        _player.Go();
    }

    private void Stop()
    {
        _player.Stop();
    }
}
