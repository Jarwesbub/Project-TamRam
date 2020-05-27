using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXScript : MonoBehaviour
{
    public AudioSource FightTransition;
    public AudioSource BasicAttack;
    public AudioSource BurnStay;
    public AudioSource SuperAttack;
    public AudioSource UltraAttack;
    public AudioSource XPScreen;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PersistentManagerScript.Instance.FightTransition == true)
        {
            FightTransition.Play();

        }

        if (PersistentManagerScript.Instance.XPScreen == 1)
        {
            XPScreen.Play();

        }
        if (PersistentManagerScript.Instance.PlayerClass == 1 || PersistentManagerScript.Instance.PlayerClass == 2 || PersistentManagerScript.Instance.PlayerClass == 3)
        {
            if (PersistentManagerScript.Instance.BasicAttack == true)
            {
                BasicAttack.Play();

            }

        }

        if (PersistentManagerScript.Instance.SuperAttack == true)
        {
            SuperAttack.Play();
        }

        if (PersistentManagerScript.Instance.UltraAttack == true)
        {
            UltraAttack.Play();
        }

        if (PersistentManagerScript.Instance.BurnActive == true)
        {
            BurnStay.Play();
        }
    }
}
