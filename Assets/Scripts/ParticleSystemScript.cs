using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemScript : MonoBehaviour
{
    public GameObject ParticleEffects;
    public GameObject StunAttack;
    public GameObject StunGet;
    public GameObject WeakenAttack;
    public GameObject WeakenStay;
    public GameObject WarriorDefense;
    public GameObject BurnAttack;
    public GameObject BurnStay;
    public GameObject ConfAttack;
    public GameObject ConfDamage;
    public GameObject PoisonAttack;
    public GameObject PoisonStay;
    public GameObject SlowAttack;
    public GameObject SlowStay;
    public GameObject Class3BasicAttack;

    public GameObject GetHP;

    public int ActiveDefense = 0;
    public int ActiveSuper = 0; // When Particle system starts in Update()
    public int ActiveUltra = 0;

    // StayNumb 13 -> First letter = Class number
    // StayNumb 13 -> Second Letter = Attack number: 1 = basic, 2 = super, 3 = ultra, 4 = defense


    IEnumerator StayWait(int StayNumb)
    {
        int Stay = StayNumb;
        yield return new WaitForSeconds(0.5f);

        if (Stay == 13)
            WeakenStay.GetComponent<ParticleSystem>().Play();

        if (Stay == 22)
            PoisonStay.GetComponent<ParticleSystem>().Play();

        if (Stay == 23)
            SlowStay.GetComponent<ParticleSystem>().Play();

        if (Stay == 32)
            ConfDamage.GetComponent<ParticleSystem>().Play();

        if (Stay == 33)
            BurnStay.GetComponent<ParticleSystem>().Play();

        yield return Stay;

        
    }


    // Update is called once per frame
    void Update()
    {
        if (PersistentManagerScript.Instance.FightScreen == true)
        {
            ParticleEffects.SetActive(true);
        }
        else
        {
            ParticleEffects.SetActive(false);
        }

        if (PersistentManagerScript.Instance.BasicAttack == true && PersistentManagerScript.Instance.PlayerClass == 3)
        {
            Class3BasicAttack.GetComponent<ParticleSystem>().Play();
        }


        if (PersistentManagerScript.Instance.BasicDefense == true)
        {
            ActiveDefense = 0;
        }
        if (PersistentManagerScript.Instance.SuperAttack == true)
        {
            ActiveSuper = 0;
        }
        if (PersistentManagerScript.Instance.UltraAttack == true)
        {
            ActiveUltra = 0;
        }

        if (PersistentManagerScript.Instance.BasicDefense == true)
        {
            WarriorDefense.GetComponent<ParticleSystem>().Play();
        }

        if (PersistentManagerScript.Instance.SuperAttack == true && PersistentManagerScript.Instance.PlayerClass == 1)
        {
            StunAttack.GetComponent<ParticleSystem>().Play();
        }

        if (PersistentManagerScript.Instance.UltraAttack == true && PersistentManagerScript.Instance.PlayerClass == 1)
        {
            
            WeakenAttack.GetComponent<ParticleSystem>().Play();
            for (int i = ActiveUltra; i < 1; i++)
            {
                StartCoroutine(StayWait(13));
                //WeakenStay.GetComponent<ParticleSystem>().Play();
                ActiveUltra += 1;
            }
        }

        if (PersistentManagerScript.Instance.SuperAttack == true && PersistentManagerScript.Instance.PlayerClass == 2)
        {
            PoisonAttack.GetComponent<ParticleSystem>().Play();
            for (int i = ActiveSuper; i < 1; i++)
            {
                StartCoroutine(StayWait(22));
                //PoisonStay.GetComponent<ParticleSystem>().Play();
                ActiveSuper += 1;
            }
        }


        if (PersistentManagerScript.Instance.UltraAttack == true && PersistentManagerScript.Instance.PlayerClass == 2)
        {
            SlowAttack.GetComponent<ParticleSystem>().Play();
            for (int i = ActiveUltra; i < 1; i++)
            {
                StartCoroutine(StayWait(23));
                //SlowStay.GetComponent<ParticleSystem>().Play();
                ActiveUltra += 1;
            }
            
        }

        if (PersistentManagerScript.Instance.UltraAttack == true && PersistentManagerScript.Instance.PlayerClass == 3)
        {
            BurnAttack.GetComponent<ParticleSystem>().Play();
            for (int i = ActiveUltra; i < 1; i++)
            {
                StartCoroutine(StayWait(33));
                //BurnStay.GetComponent<ParticleSystem>().Play();
                ActiveUltra += 1;
            }
        }

        if (PersistentManagerScript.Instance.SuperAttack == true && PersistentManagerScript.Instance.PlayerClass == 3)
        {
            ConfAttack.GetComponent<ParticleSystem>().Play();
            for (int i = ActiveSuper; i < 1; i++)
            {
                StartCoroutine(StayWait(32));
                //ConfDamage.GetComponent<ParticleSystem>().Play();
                ActiveSuper += 1;
            }
        }

        
        if (PersistentManagerScript.Instance.StunActive == true)
        {
            for (int i = ActiveSuper; i < 1; i++)
            {
                StunGet.GetComponent<ParticleSystem>().Play();
                ActiveSuper += 1;
            }
        }
        else
        {
            StunGet.GetComponent<ParticleSystem>().Stop();
        }
        

        if (PersistentManagerScript.Instance.StunActive == false && PersistentManagerScript.Instance.PlayerTurn == true)
        {
            StunGet.GetComponent<ParticleSystem>().Stop();
        }

        if (PersistentManagerScript.Instance.WeakenActive == false && PersistentManagerScript.Instance.PlayerTurn == true)
        {
            WeakenStay.GetComponent<ParticleSystem>().Stop();
        }

        if (PersistentManagerScript.Instance.PoisonActive == false && PersistentManagerScript.Instance.PlayerTurn == true)
        {
            PoisonStay.GetComponent<ParticleSystem>().Stop();
        }


        if (PersistentManagerScript.Instance.SlowActive == false && PersistentManagerScript.Instance.PlayerTurn == true)
        {
            SlowStay.GetComponent<ParticleSystem>().Stop();
        }


        if (PersistentManagerScript.Instance.BurnActive == false && PersistentManagerScript.Instance.PlayerTurn == true)
        {
            BurnStay.GetComponent<ParticleSystem>().Stop();
        }


        if (PersistentManagerScript.Instance.ConfusionActive == false && PersistentManagerScript.Instance.PlayerTurn == true)
        {

            ConfDamage.GetComponent<ParticleSystem>().Stop();
        }

        if (PersistentManagerScript.Instance.EnDies >= 1)
        {
            WeakenStay.GetComponent<ParticleSystem>().Stop();
            PoisonStay.GetComponent<ParticleSystem>().Stop();
            SlowStay.GetComponent<ParticleSystem>().Stop();
            ConfDamage.GetComponent<ParticleSystem>().Stop();
            BurnStay.GetComponent<ParticleSystem>().Stop();
        }

        

    }




    public void GetHPTamaScreen()
    {
        GetHP.GetComponent<ParticleSystem>().Play();
        PersistentManagerScript.Instance.PlayerHealth = PersistentManagerScript.Instance.PlayerMaxHealth;
    }



}
