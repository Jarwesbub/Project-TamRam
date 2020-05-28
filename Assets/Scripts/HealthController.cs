using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    //public static HealthController Instance { get; set; }   // Testing if works better as Singleton
    public GameObject PlayerKill;
    public int maxHealth;
    public int currentHealth;
    public AudioSource Death;
    public HealthBarScript healthBar;

    public bool GameStart;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = PersistentManagerScript.Instance.PlayerMaxHealth;
        currentHealth = PersistentManagerScript.Instance.PlayerMaxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }


    void Update()
    {
        currentHealth = PersistentManagerScript.Instance.PlayerHealth;
        healthBar.SetHealth(currentHealth);


        if (GameStart == true)
        {
            currentHealth = PersistentManagerScript.Instance.Con * 10;

            GameStart = false;
        }



        
        if (currentHealth <= 0)
        {
            StartCoroutine(PlayerDeath());

        }
        

    }
    
    IEnumerator PlayerDeath()
    {
        PersistentManagerScript.Instance.PlayerTurn = false;
        yield return new WaitForSeconds(0.5f);

        PersistentManagerScript.Instance.PlayerDies = true;

        yield return new WaitForSeconds(1f);

        //PersistentManagerScript.Instance.GameReset = true;
        PersistentManagerScript.Instance.FightScreen = false;
        SceneManager.LoadScene("GameoverScene");

    }
    
}

/*
        if (PersistentManagerScript.Instance.PlayerClass == 1 || PersistentManagerScript.Instance.PlayerClass == 2 || PersistentManagerScript.Instance.PlayerClass == 3)
        {
            if (PersistentManagerScript.Instance.PlayerHealth +1 >= PersistentManagerScript.Instance.PlayerMaxHealth)
            {
                PersistentManagerScript.Instance.PlayerHealth = PersistentManagerScript.Instance.PlayerMaxHealth;
            }
        }
    }
    */