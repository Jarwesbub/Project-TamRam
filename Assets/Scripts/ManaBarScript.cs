using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBarScript : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    //public GameObject border;
    //public float Value;
    public bool ManaGet = false; // When game start -> this is false as long as player gets his mana for the first time

    void Start()
    {
        //PersistentManagerScript.Instance.PlayerMana = PersistentManagerScript.Instance.maxMana;

    }


     public void SetMaxHealth(int health)
    {
        health = PersistentManagerScript.Instance.maxMana;
        slider.maxValue = PersistentManagerScript.Instance.maxMana;
        slider.value = health;

        fill.color = gradient.Evaluate(1f);

    }


    public void SetHealth(int health)
    {
        //PersistentManagerScript.Instance.PlayerMana = PersistentManagerScript.Instance.maxMana;
        health = PersistentManagerScript.Instance.PlayerMana;

        slider.value = PersistentManagerScript.Instance.PlayerMana;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    void Update()
    {
        if (PersistentManagerScript.Instance.PlayerMana == 0 && ManaGet == false)
        {
            PersistentManagerScript.Instance.PlayerMana = PersistentManagerScript.Instance.maxMana;
        }
        else
        {
            ManaGet = true;
        }



        slider.maxValue = PersistentManagerScript.Instance.maxMana;
        slider.value = PersistentManagerScript.Instance.PlayerMana;

    }

}
