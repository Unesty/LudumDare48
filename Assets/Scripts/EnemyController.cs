using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    enum _states {
        idle,
        attack,
        grab
    }
    [SerializeField] private _states _state;
    [SerializeField] private float _time;
    [SerializeField] private float _timer;
    [SerializeField] Animator animator;
    [SerializeField] GameObject _victim;
    [SerializeField] float _step;
    [SerializeField] CharonController _charon;
    [SerializeField] int HP=10;

    //private List<GameObject> _enemys;

    void Awake()
    {
        _charon = GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<CharonController>();
        _victim = _charon._victim;
        animator = GetComponent<Animator>();
    }
    
    private void Update()
    {
        if(_charon.attacking) Damage();
        switch (_state)
        {
            case _states.idle:
                animator.SetBool("attack",false);
                animator.SetBool("grab",false);
                break;
            case _states.attack:
                animator.SetBool("attack",true);
                animator.SetBool("grab",false);
                break;
            case _states.grab:
                animator.SetBool("attack",false);
                animator.SetBool("grab",true);
                break;
        }
        transform.position = Vector3.MoveTowards(transform.position, _victim.transform.position, _step);
    }
    public void Damage()
    {
        HP--;
        if(HP<=0) Destroy(this.gameObject);
        animator.SetTrigger("damage");
    }
}
