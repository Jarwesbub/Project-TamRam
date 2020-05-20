using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillPointsVisible : MonoBehaviour
{
    public GameObject Str;
    public GameObject Dex;
    public GameObject Int;
    public GameObject Wis;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PersistentManagerScript.Instance.PlayerClass == 1)
        {
            Str.SetActive(true);
        }
        else
        {
            Str.SetActive(false);
        }

        if (PersistentManagerScript.Instance.PlayerClass == 2)
        {
            Dex.SetActive(true);
        }
        else
        {
            Dex.SetActive(false);
        }

        if (PersistentManagerScript.Instance.PlayerClass == 3)
        {
            Int.SetActive(true);
        }
        else
        {
            Int.SetActive(false);
        }

    }
}
