using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TamaScreenPet : MonoBehaviour
{
    public GameObject TamaClass1;
    public GameObject TamaClass2;
    public GameObject TamaClass3;

    Animator animator;
    Animation anim;

    //public GameObject TamaPlayer;
    public GameObject SleepTextObj;

    // Start is called before the first frame update
    void Update()
    {
        if (PersistentManagerScript.Instance.PlayerClass == 1)
        {
            animator = TamaClass1.GetComponent<Animator>();
            anim = TamaClass1.GetComponent<Animation>();
        }

        if (PersistentManagerScript.Instance.PlayerClass == 2)
        {
            animator = TamaClass2.GetComponent<Animator>();
            anim = TamaClass2.GetComponent<Animation>();
        }

        if (PersistentManagerScript.Instance.PlayerClass == 3)
        {
            animator = TamaClass3.GetComponent<Animator>();
            anim = TamaClass3.GetComponent<Animation>();
        }
    }

    public void PetAnimationEnd()
    {

    }


    public void PetButton()
    {
        anim.Play();
        animator.SetTrigger("PetButton");

    }
}
