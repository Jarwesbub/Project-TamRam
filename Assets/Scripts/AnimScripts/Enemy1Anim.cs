using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Anim : MonoBehaviour
{
    public Animation anim;
    public Animator animator;

    public int AnimPlay = 0;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        anim = GetComponent<Animation>();

    }

    // Update is called once per frame
    void Update()
    {

        if (PersistentManagerScript.Instance.EnemyAnimAttack == true)
        {
            anim.Play();
            animator.SetTrigger("BasicAttack");
            PersistentManagerScript.Instance.EnemyAnimAttack = false;
        }

    }

    public void AnimationEnd()
    {


    }


}

