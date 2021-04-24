using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogeLoader : MonoBehaviour
{
    [SerializeField] private DialogPlayer _dialogPlayer;
    [SerializeField] private string _fileTitle;

    private void Awake()
    {
        TextAsset mytxtData = (TextAsset)Resources.Load(_fileTitle);
        Queue<Dialog> dialogs = JsonConvert.DeserializeObject<Queue<Dialog>>(mytxtData.text);
        _dialogPlayer.SetDialogs(dialogs);
    }
}
