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

    void Kill()
    {
        //Destroy(gameObject);
        animator.SetTrigger("PlayerReset");
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (PersistentManagerScript.Instance.FightTransition == true)
        {
            if (PersistentManagerScript.Instance.PlayerClass == 1 || PersistentManagerScript.Instance.PlayerClass == 2)
                anim.Play("warrior_idle");

            if (PersistentManagerScript.Instance.PlayerClass == 3)
                anim.Play("witch_idle");
        }
        */

        if (PersistentManagerScript.Instance.PlayerDies == true)
        {
            PersistentManagerScript.Instance.PlayerDies = false;
            animator.SetTrigger("PlayerDies");

            /*
            if (AnimPlay == 0 && Input.GetKeyDown("x"))
            {
                anim.Play();
                animator.SetTrigger("BasicAttack");

            }
            */

        }

        if (PersistentManagerScript.Instance.PlayerClass == 1 || PersistentManagerScript.Instance.PlayerClass == 2)
        {
            if (PersistentManagerScript.Instance.BasicAnimAttack == true)
            {
                //anim.Play();
                animator.SetTrigger("BasicAttack");
                PersistentManagerScript.Instance.BasicAnimAttack = false;
            }
            if (PersistentManagerScript.Instance.BasicAnimTackle == true)
            {
                //anim.Play();
                animator.SetTrigger("BasicTackle");
                PersistentManagerScript.Instance.BasicAnimTackle = false;
            }
            if (PersistentManagerScript.Instance.BasicAnimJumphit == true)
            {
                //anim.Play();
                animator.SetTrigger("BasicJumphit");
                PersistentManagerScript.Instance.BasicAnimJumphit = false;
            }

        }
    }

}
