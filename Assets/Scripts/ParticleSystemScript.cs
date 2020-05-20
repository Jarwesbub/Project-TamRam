using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemScript : MonoBehaviour
{
    public GameObject ParticleEffects;
    public GameObject StunAttack;
    public GameObject StunGet;
    public GameObject WarriorDefense;
    public GameObject BurnAttack;
    public GameObject BurnStay;
    public GameObject ConfAttack;
    public GameObject ConfDamage;
    public GameObject PoisonAttack;
    public GameObject PoisonStay;
    public GameObject SlowAttack;
    public GameObject SlowStay;

    public GameObject GetHP;

    public int ActiveDefense = 0;
    public int ActiveSuper = 0; // When Particle system starts in Update()
    public int ActiveUltra = 0;





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

        if (PersistentManagerScript.Instance.BasicDefense == true && PersistentManagerScript.Instance.PlayerClass == 1)
        {
            WarriorDefense.GetComponent<ParticleSystem>().Play();
        }

        if (PersistentManagerScript.Instance.SuperAttack == true && PersistentManagerScript.Instance.PlayerClass == 1)
        {
            StunAttack.GetComponent<ParticleSystem>().Play();
        }


        if (PersistentManagerScript.Instance.SuperAttack == true && PersistentManagerScript.Instance.PlayerClass == 2)
        {
            PoisonAttack.GetComponent<ParticleSystem>().Play();
        }


        if (PersistentManagerScript.Instance.UltraAttack == true && PersistentManagerScript.Instance.PlayerClass == 2)
        {
            SlowAttack.GetComponent<ParticleSystem>().Play();
        }

        if (PersistentManagerScript.Instance.UltraAttack == true && PersistentManagerScript.Instance.PlayerClass == 3)
        {
            BurnAttack.GetComponent<ParticleSystem>().Play();
        }

        if (PersistentManagerScript.Instance.SuperAttack == true && PersistentManagerScript.Instance.PlayerClass == 3)
        {
            ConfAttack.GetComponent<ParticleSystem>().Play();
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


        if (PersistentManagerScript.Instance.PoisonActive == true)
        {
            for (int i = ActiveSuper; i < 1; i++)
            {
                PoisonStay.GetComponent<ParticleSystem>().Play();
                ActiveSuper += 1;
            }
        }
        else
        {
            PoisonStay.GetComponent<ParticleSystem>().Stop();
        }

        if (PersistentManagerScript.Instance.SlowActive == true)
        {
            for (int i = ActiveUltra; i < 1; i++)
            {
                SlowStay.GetComponent<ParticleSystem>().Play();
                ActiveUltra += 1;
            }
        }
        else
        {
            SlowStay.GetComponent<ParticleSystem>().Stop();
        }

        if (PersistentManagerScript.Instance.BurnActive == true)
        {
            for (int i = ActiveUltra; i < 1; i++)
            {
                BurnStay.GetComponent<ParticleSystem>().Play();
                ActiveUltra += 1;
            }
        }
        else
        {
            BurnStay.GetComponent<ParticleSystem>().Stop();
        }


        if (PersistentManagerScript.Instance.ConfusionActive == true)
        {
            for (int i = ActiveSuper; i < 1; i++)
            {
                ConfDamage.GetComponent<ParticleSystem>().Play();
                ActiveSuper += 1;
            }
        }
        else
        {
            ConfDamage.GetComponent<ParticleSystem>().Stop();
        }



        

    }




    public void GetHPTamaScreen()
    {
        GetHP.GetComponent<ParticleSystem>().Play();
        PersistentManagerScript.Instance.PlayerHealth = 100;
    }



}
