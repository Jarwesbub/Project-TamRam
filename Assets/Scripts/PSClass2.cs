using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSClass2 : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        if (PersistentManagerScript.Instance.GameStart == true)
        {
            PersistentManagerScript.Instance.Lvl = 1;
            PersistentManagerScript.Instance.PlayerHealth = 90;
            PersistentManagerScript.Instance.GameStart = false;
        }



    }

    // Update is called once per frame
    void Update()
    {
        if (PersistentManagerScript.Instance.Lvl == 1)
        {
            /*
            PersistentManagerScript.Instance.Str = 8; // 8
            PersistentManagerScript.Instance.Con = 9; // 9
            PersistentManagerScript.Instance.Dex = 13; // 13
            PersistentManagerScript.Instance.Agi = 12; // 12
            PersistentManagerScript.Instance.Int = 9; // 9
            PersistentManagerScript.Instance.Luck = 10; // 10
            PersistentManagerScript.Instance.Wis = 10; // 10
            */
                     
           PersistentManagerScript.Instance.Str = 22;
           PersistentManagerScript.Instance.Con = 22;
           PersistentManagerScript.Instance.Dex = 22;
           PersistentManagerScript.Instance.Agi = 22;
           PersistentManagerScript.Instance.Int = 22;
           PersistentManagerScript.Instance.Luck = 22;
           PersistentManagerScript.Instance.Wis = 22;
           

        }

    }
}
