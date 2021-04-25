using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOpenClose : MonoBehaviour
{
    [SerializeField] private Mover _player;
    [SerializeField] private Animator _darkPanel;
    [SerializeField] private string _nextSceneTitle;

    private void Awake()
    {
        _darkPanel.Play("ShowScene");
        IdleEndAnimation();
        _player.Go();
    }

    private IEnumerator PanelDeactivator(float lenght)
    {
        yield return new WaitForSeconds(lenght);
        _darkPanel.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Boat>(out Boat boat))
        {
            _darkPanel.gameObject.SetActive(true);
            _darkPanel.Play("HideScene");
            IdleEndAnimation();
            NextScene();
        }
    }

    private void IdleEndAnimation()
    {
        AnimatorClipInfo[] stInfos = _darkPanel.GetCurrentAnimatorClipInfo(0);
        AnimationClip clip = stInfos.Length > 0 ? stInfos[0].clip : null;
        StartCoroutine(PanelDeactivator(clip?.length ?? 2));
    }

    private void NextScene()
    {
        if (_nextSceneTitle != string.Empty && _nextSceneTitle != null)
            SceneManager.LoadScene(_nextSceneTitle);
    }
}
