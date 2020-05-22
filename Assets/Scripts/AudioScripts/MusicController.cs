using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource FightMusic;
    public Animator MusicAnim;


    public bool ThemeCheck = false;

    void Start()
    {
        MusicAnim = GetComponent<Animator>();
        //MusicAnim = GetComponent<Animation>();

    }


    // Update is called once per frame
    void Update()
    {
        if (PersistentManagerScript.Instance.FightTransition == true && ThemeCheck == false)
        {
            //MusicAnim.SetTrigger("FadeIn");
            FightMusic.Play();

            ThemeCheck = true;
        }
        if (PersistentManagerScript.Instance.EnDies == 1 || PersistentManagerScript.Instance.Run == true)
        {
            //MusicAnim.SetTrigger("FadeOut");
            FightMusic.Stop();
            ThemeCheck = false;
        }


        /*
        if (PersistentManagerScript.Instance.EnDies == 1)
        {
            FightMusic.Stop();
            ThemeCheck = false;
        }
        */

        
    }
    /*
    void MusicStop()
    {
        FightMusic.Stop();
        ThemeCheck = false;

    }
    */

}
