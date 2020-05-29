using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource MusicMap1;
    public AudioSource MusicMap2;
    public AudioSource MusicMap3;
    public AudioSource MusicMap4;
    public AudioSource MusicMap5;
    public AudioSource FightTransition;
    public AudioSource FightMap2;
    public AudioSource FightMap3;
    public AudioSource FightMap4;
    public AudioSource FightMap5;

    public Animator MusicAnim;

    int CurrentMap = -1;
    public bool ThemeCheck = false;

    void Start()
    {
        MusicAnim = GetComponent<Animator>();
        //MusicAnim = GetComponent<Animation>();
        
    }


    // Update is called once per frame
    void Update()
    {
        if (PersistentManagerScript.Instance.FightMusicStart == true && ThemeCheck == false)
        {
            FightTransition.Play();
            //MusicChange();
            MusicAnim.SetTrigger("FightMusicStart");
            ThemeCheck = true;
        }
        

        if (PersistentManagerScript.Instance.PlayerCanMove == true && ThemeCheck == true)
        {
            ThemeCheck = false;
            PersistentManagerScript.Instance.FightMusicStart = false;
            MusicAnim.SetTrigger("FightMusicEnd");
            MusicAnim.SetTrigger("FadeOutIn");
            
            ThemeCheck = false;

        }

        if (PersistentManagerScript.Instance.WorldMapPos != CurrentMap)
        {
            MusicAnim.SetTrigger("FadeOutIn");
            CurrentMap = PersistentManagerScript.Instance.WorldMapPos;
        }


    }
    
    void MusicChange()
    {
        MusicMap1.Pause();
        MusicMap2.Pause();
        MusicMap3.Pause();
        MusicMap4.Pause();
        MusicMap5.Pause();
        if (PersistentManagerScript.Instance.FightMusicStart == false)
        {
            FightMap2.Stop();
            FightMap3.Stop();
            FightMap4.Stop();
            FightMap5.Stop();

            
            if (PersistentManagerScript.Instance.WorldMapPos == 0)
            {
                //MusicMap1.Play();

            }
            if (PersistentManagerScript.Instance.WorldMapPos == 1)
            {
                MusicMap1.Play();

            }

            if (PersistentManagerScript.Instance.WorldMapPos == 2)
            {
                MusicMap2.Play();

            }

            if (PersistentManagerScript.Instance.WorldMapPos == 3)
            {
                MusicMap3.Play();

            }
            if (PersistentManagerScript.Instance.WorldMapPos == 4)
            {
                MusicMap4.Play();

            }
            if (PersistentManagerScript.Instance.WorldMapPos == 5)
            {
                MusicMap5.Play();

            }
        }
        else
        {


            if (PersistentManagerScript.Instance.WorldMapPos == 2)
            {
                FightMap2.Play();
            }
            if (PersistentManagerScript.Instance.WorldMapPos == 3)
            {
                FightMap3.Play();
            }
            if (PersistentManagerScript.Instance.WorldMapPos == 4)
            {
                FightMap4.Play();
            }
            if (PersistentManagerScript.Instance.WorldMapPos == 5)
            {
                FightMap5.Play();
            }
        }
        /*
        if (PersistentManagerScript.Instance.FightMusicStart == false)
        {
            MusicAnim.SetTrigger("FightMusicEnd");
        }
        */
        MusicAnim.SetTrigger("Next");

    }
    

}
