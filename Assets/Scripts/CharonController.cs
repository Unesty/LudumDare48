using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharonController : MonoBehaviour
{
    public bool attacking=false;
    [SerializeField]
    Vector2 bounds;
    [SerializeField]
    float speed;
    [SerializeField]
    Animator animator;
    [SerializeField]
    EnemySpawner _enemySpawner;
    public GameObject _victim;
    
    [SerializeField]
    AudioSource audioSource;
    [SerializeField]
    AudioClip hitSound;
    
    enum states {
        swim,
        fight
    }
    
    [SerializeField]
    states currentState = states.swim;
    
    Vector3 initScale;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        initScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("FightAttack")) {
            attacking = true;
        } else if(Input.GetButtonDown("Jump")) {
            audioSource.PlayOneShot(hitSound,0.5f);
            animator.SetBool("Stoped",false);
            animator.SetBool("Going",false);
            animator.SetBool("FightIdle",false);
            animator.SetBool("FightAttack",true);
            animator.SetBool("FightWalk",false); 
        } else if(Input.GetAxis("Horizontal")<0 && transform.localPosition.x>bounds[0]) {
            attacking = false;
            //transform.localScale = new Vector3(-initScale,;
            if(currentState==states.swim) {
                animator.SetBool("Stoped",false);
                animator.SetBool("Going",true);
                animator.SetBool("FightIdle",false);
                animator.SetBool("FightAttack",false);
                animator.SetBool("FightWalk",false);
            }
            if(currentState==states.fight) {
                animator.SetBool("Stoped",false);
                animator.SetBool("Going",false);
                animator.SetBool("FightIdle",false);
                animator.SetBool("FightAttack",false);
                animator.SetBool("FightWalk",true);
            }
            transform.Translate(new Vector3(speed*Input.GetAxis("Horizontal"),0,0));
        } else if(Input.GetAxis("Horizontal")>0 && transform.localPosition.x<bounds[1]) {
            attacking = false;
            if(currentState==states.swim) {
                animator.SetBool("Stoped",false);
                animator.SetBool("Going",true);
                animator.SetBool("FightIdle",false);
                animator.SetBool("FightAttack",false);
                animator.SetBool("FightWalk",false);
            }
            if(currentState==states.fight) {
                animator.SetBool("Stoped",false);
                animator.SetBool("Going",false);
                animator.SetBool("FightIdle",false);
                animator.SetBool("FightAttack",false);
                animator.SetBool("FightWalk",true);
            }
            transform.Translate(new Vector3(speed*Input.GetAxis("Horizontal"),0,0));
        } else {
            attacking = false;
            if(currentState==states.swim) {
                animator.SetBool("Stoped",true);
                animator.SetBool("Going",false);
                animator.SetBool("FightIdle",false);
                animator.SetBool("FightAttack",false);
                animator.SetBool("FightWalk",false);
            }
            if(currentState==states.fight) {
                animator.SetBool("Stoped",false);
                animator.SetBool("Going",false);
                animator.SetBool("FightIdle",true);
                animator.SetBool("FightAttack",false);
                animator.SetBool("FightWalk",false);
            }
        }
    }
}
