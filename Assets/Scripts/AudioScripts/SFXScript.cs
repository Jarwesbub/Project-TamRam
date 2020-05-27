using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXScript : MonoBehaviour
{
    public AudioSource FightTransition;
    public AudioSource BasicAttack;
    public AudioSource BurnActive;
    public AudioSource SuperAttack;
    public AudioSource UltraAttack;
    public AudioSource XPScreen;
    public AudioSource Die1;
    /*
    public AudioSource C1Ultra; // Class 1 Ultra
    public AudioSource C2Super; // Class 2 Super
    public AudioSource C2Ultra; // Class 2 Ultra
    public AudioSource C3Basic;
    public AudioSource C3Super; // Class 3 Super
    public AudioSource C3Ultra; // Class 3 Ultra
    */

    bool EnemyDies = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    IEnumerator EnemyAttack()
    {
        if (PersistentManagerScript.Instance.StunActive == false)
        {
            yield return new WaitForSeconds(0.2f);
            if (PersistentManagerScript.Instance.EnLvl <= 5)
            {
                BasicAttack.Play();
            }

            if (PersistentManagerScript.Instance.EnLvl >= 5 && PersistentManagerScript.Instance.EnLvl <= 10)
            {
                SuperAttack.Play();
            }

            if (PersistentManagerScript.Instance.EnLvl >= 10)
            {
                UltraAttack.Play();
            }

        }
    }


    // Update is called once per frame
    void Update()
    {
        if (PersistentManagerScript.Instance.FightTransition == true)
        {
            FightTransition.Play();
            EnemyDies = false;
        }

        if (PersistentManagerScript.Instance.EnemyTurn == true)
        {
            //StartCoroutine(EnemyAttack());
        }

        /*
        if (PersistentManagerScript.Instance.XPScreen == 1)
        {
            if (EnemyDies == false)
            {
                XPScreen.Play();
                EnemyDies = true;
            }
        }
        */

        /*
        if (PersistentManagerScript.Instance.PlayerClass == 1)
        {
            if (PersistentManagerScript.Instance.BasicAttack == true)
            {
                    BasicAttack.Play();
            }
            if (PersistentManagerScript.Instance.SuperAttack == true)
            {
                SuperAttack.Play();
            }

            if (PersistentManagerScript.Instance.UltraAttack == true)
            {
                //C1Ultra.Play();
                UltraAttack.Play();
            }
        }



        if (PersistentManagerScript.Instance.PlayerClass == 2)
        {
            if (PersistentManagerScript.Instance.BasicAttack == true)
            {
                BasicAttack.Play();
            }

            if (PersistentManagerScript.Instance.SuperAttack == true)
            {
                C2Super.Play();
            }

            if (PersistentManagerScript.Instance.UltraAttack == true)
            {
                C2Ultra.Play();
            }

        }



        if (PersistentManagerScript.Instance.PlayerClass == 3)
        {
            if (PersistentManagerScript.Instance.BasicAttack == true)
            {
                C3Basic.Play();
            }

            if (PersistentManagerScript.Instance.SuperAttack == true)
            {
                C3Super.Play();
            }

            if (PersistentManagerScript.Instance.UltraAttack == true)
            {
                C3Ultra.Play();
            }

            if (PersistentManagerScript.Instance.BurnActive == true)
            {
                BurnActive.Play();
            }
        }

    */


    }
}
