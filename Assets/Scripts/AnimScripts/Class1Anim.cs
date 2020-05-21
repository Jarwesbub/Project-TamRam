using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class1Anim : MonoBehaviour
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


        if (AnimPlay == 0 && Input.GetKeyDown("x"))
        {
            anim.Play();
            animator.SetTrigger("BasicAttack");

        }
        if (PersistentManagerScript.Instance.BasicAnimAttack == true)
        {
            anim.Play();
            animator.SetTrigger("BasicAttack");
            PersistentManagerScript.Instance.BasicAnimAttack = false;
        }

    }

    public void AnimationEnd()
    {


    }


}
