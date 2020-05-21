using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    //public GameObject border;
    //public float Value;

    public void SetMaxHealth(int health)
    {
        //health = PersistentManagerScript.Instance.PlayerHealth;
        slider.maxValue = PersistentManagerScript.Instance.PlayerMaxHealth;
        slider.value = health;

        fill.color = gradient.Evaluate(1f);

    }


    public void SetHealth(int health)
    {
        slider.value = health;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
    
    void Update()
    {
        slider.maxValue = PersistentManagerScript.Instance.PlayerMaxHealth;

        /*
        Value = slider.value;

        border.transform.localScale = new Vector2(Value / 100,1);
        */



    }
    
}
