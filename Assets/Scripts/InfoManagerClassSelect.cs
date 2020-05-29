using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoManagerClassSelect : MonoBehaviour
{
    public GameObject Info1;
    public GameObject Info2;
    public GameObject Info3;

    public AudioSource InfoSound;

    public void Info1Active()
    {
        InfoSound.Play();
        Info1.SetActive(true);
        Info2.SetActive(false);
        Info3.SetActive(false);
    }
    public void Info2Active()
    {
        InfoSound.Play();
        Info1.SetActive(false);
        Info2.SetActive(true);
        Info3.SetActive(false);
    }
    public void Info3Active()
    {
        InfoSound.Play();
        Info1.SetActive(false);
        Info2.SetActive(false);
        Info3.SetActive(true);
    }



}
