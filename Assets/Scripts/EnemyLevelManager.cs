using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLevelManager : MonoBehaviour
{
    public int EnClass;
    public int EnHealth;
    public int EnMaxHealth;
    public int EnLVL;
    public int EnStr;
    public int EnCon;
    public int EnDex;
    public int EnInt;
    public int EnAgi;

    public int PlayerLVL;
    public bool EnNewLVL = false;
    public bool FirstCheck = false;

    public GameObject MyObject;

    public int HowManyFights = 0;

    void OnEnable()
    {
        FirstCheck = true;
        EnNewLVL = true;
        EnHealth = 2;
        EnMaxHealth = 2;

    }
    /*
    IEnumerator ActiveTime()
    {
        yield return new WaitForSeconds(4f);
        MyObject.SetActive(false);
    }
    */
    void Update()
    {
        PersistentManagerScript.Instance.EnemyMaxHealth = EnMaxHealth;


        if (FirstCheck == true)
        {
            EnemyLevel();
            //DrawEnStarts();

            if (PersistentManagerScript.Instance.EnClass == 1)
            {
                EnemyClass1();
            }

            if (PersistentManagerScript.Instance.EnClass == 2)
            {
                EnemyClass2();
            }

            if (PersistentManagerScript.Instance.EnClass == 3)
            {
                EnemyClass3();
            }
            DrawEnStarts();
            EnemyHealthCalc(EnCon);
            DrawEnStarts();

            //PersistentManagerScript.Instance.EnemyHealth = PersistentManagerScript.Instance.EnemyMaxHealth;

            HowManyFights += 1;
            FirstCheck = false;

            //StartCoroutine(ActiveTime());
        }

        
    }

    public int EnemyHealthCalc(int Con) // int Con = Enemy Con
    {
        int Calc = (Con * 10);

        EnHealth = Calc;
        EnMaxHealth = EnHealth;

        return Calc;

    }


    void DrawEnStarts()
    {
        PersistentManagerScript.Instance.EnemyHealth = EnHealth;
        PersistentManagerScript.Instance.EnemyMaxHealth = EnMaxHealth;
        EnClass = PersistentManagerScript.Instance.EnClass;
        PersistentManagerScript.Instance.EnStr = EnStr;
        PersistentManagerScript.Instance.EnLVL = EnLVL;
        PersistentManagerScript.Instance.EnCon = EnCon;
        PersistentManagerScript.Instance.EnDex = EnDex;
        PersistentManagerScript.Instance.EnInt = EnInt;
        PersistentManagerScript.Instance.EnAgi = EnAgi;
        PlayerLVL = PersistentManagerScript.Instance.Lvl;


    }

    void RandomizeEnLVL(int level)
    {
        if (level == 1 && EnNewLVL == true)
        {

            EnLVL = 1;

            EnNewLVL = false;
        }


        if (level == 2 && EnNewLVL == true)
        {
            
                EnLVL = Random.Range(1, 3);

                EnNewLVL = false;
        }

        if (level == 3 && EnNewLVL == true)
        {

            EnLVL = Random.Range(1, 4);

            EnNewLVL = false;
        }

        if (level == 4 && EnNewLVL == true)
        {

            EnLVL = Random.Range(2, 5);

            EnNewLVL = false;
        }

        if (level == 5 && EnNewLVL == true)
        {

            EnLVL = Random.Range(3, 6);

            EnNewLVL = false;
        }

        if (level == 6 && EnNewLVL == true)
        {

            EnLVL = Random.Range(4, 7);

            EnNewLVL = false;
        }

        if (level == 7 && EnNewLVL == true)
        {

            EnLVL = Random.Range(5, 8);

            EnNewLVL = false;
        }

        if (level == 8 && EnNewLVL == true)
        {

            EnLVL = Random.Range(6, 9);

            EnNewLVL = false;
        }

        if (level == 9 && EnNewLVL == true)
        {

            EnLVL = Random.Range(7, 10);

            EnNewLVL = false;
        }

        if (level == 10 && EnNewLVL == true)
        {

            EnLVL = Random.Range(8, 11);

            EnNewLVL = false;
        }

    }


    void EnemyLevel()
    {
        DrawEnStarts();
        if (PlayerLVL == 1 || PlayerLVL == 2)
            {
                if (PlayerLVL == 1)
                {
                    RandomizeEnLVL(1);

                }
                else if (PlayerLVL == 2)
                {
                    RandomizeEnLVL(2);

                }

            }

            if (PlayerLVL == 3 || PlayerLVL == 4)
            {
                if (PlayerLVL == 3)
                {
                    RandomizeEnLVL(3);
                }
                else if (PlayerLVL == 4)
                {
                    RandomizeEnLVL(4);
                }
            }

            if (PlayerLVL == 5 || PlayerLVL == 6)
            {
                if (PlayerLVL == 5)
                {
                RandomizeEnLVL(5);
            }
                else if (PlayerLVL == 6)
                {
                RandomizeEnLVL(6);
            }
            }
            if (PlayerLVL == 7 || PlayerLVL == 8)
            {
                if (PlayerLVL == 7)
                {
                RandomizeEnLVL(7);
            }
                else if (PlayerLVL == 8)
                {
                RandomizeEnLVL(8);
            }
            }
            if (PlayerLVL == 9 || PlayerLVL == 10)
            {
                if (PlayerLVL == 9)
                {
                RandomizeEnLVL(9);
            }
                else if (PlayerLVL == 10)
                {
                RandomizeEnLVL(10); 
            }
            }

       
    }

    void EnemyClass1() /////////////////////////////////
    {
        DrawEnStarts();

        if (EnLVL == 1)
        {
            EnStr = 13;
            EnCon = 3;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 8;
        }

        if (EnLVL == 2)
        {
            EnStr = 13;
            EnCon = 2;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 8;
        }

        if (EnLVL == 3)
        {
            EnStr = 14;
            EnCon = 3;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 8;
        }

        if (EnLVL == 4)
        {
            EnStr = 16;
            EnCon = 4;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 9;
        }

        if (EnLVL == 5)
        {
            EnStr = 17;
            EnCon = 5;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 10;
        }

        if (EnLVL == 6)
        {
            EnStr = 18;
            EnCon = 6;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 10;
        }

        if (EnLVL == 7)
        {
            EnStr = 20;
            EnCon = 7;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 12;
        }

        if (EnLVL == 8)
        {
            EnStr = 22;
            EnCon = 11;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 14;
        }

        if (EnLVL == 9)
        {
            EnStr = 24;
            EnCon = 13;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 16;
        }

        if (EnLVL == 10)
        {
            EnStr = 26;
            EnCon = 15;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 19;
        }
        DrawEnStarts();
    }

    void EnemyClass2() /////////////////////////////////
    {
        DrawEnStarts();

        if (EnLVL == 1)
        {
            EnStr = 0;
            EnCon = 3;
            EnDex = 13;
            EnInt = 0;
            EnAgi = 11;
        }

        if (EnLVL == 2)
        {
            EnStr = 13;
            EnCon = 2;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 8;
        }

        if (EnLVL == 3)
        {
            EnStr = 14;
            EnCon = 3;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 8;
        }

        if (EnLVL == 4)
        {
            EnStr = 16;
            EnCon = 4;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 9;
        }

        if (EnLVL == 5)
        {
            EnStr = 17;
            EnCon = 5;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 10;
        }

        if (EnLVL == 6)
        {
            EnStr = 18;
            EnCon = 6;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 10;
        }

        if (EnLVL == 7)
        {
            EnStr = 20;
            EnCon = 7;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 12;
        }

        if (EnLVL == 8)
        {
            EnStr = 22;
            EnCon = 11;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 14;
        }

        if (EnLVL == 9)
        {
            EnStr = 24;
            EnCon = 13;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 16;
        }

        if (EnLVL == 10)
        {
            EnStr = 26;
            EnCon = 15;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 19;
        }
        DrawEnStarts();
    }

    void EnemyClass3() /////////////////////////////////
    {
        DrawEnStarts();

        if (EnLVL == 1)
        {
            EnStr = 0;
            EnCon = 3;
            EnDex = 0;
            EnInt = 13;
            EnAgi = 8;
        }

        if (EnLVL == 2)
        {
            EnStr = 13;
            EnCon = 2;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 8;
        }

        if (EnLVL == 3)
        {
            EnStr = 14;
            EnCon = 3;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 8;
        }

        if (EnLVL == 4)
        {
            EnStr = 16;
            EnCon = 4;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 9;
        }

        if (EnLVL == 5)
        {
            EnStr = 17;
            EnCon = 5;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 10;
        }

        if (EnLVL == 6)
        {
            EnStr = 18;
            EnCon = 6;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 10;
        }

        if (EnLVL == 7)
        {
            EnStr = 20;
            EnCon = 7;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 12;
        }

        if (EnLVL == 8)
        {
            EnStr = 22;
            EnCon = 11;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 14;
        }

        if (EnLVL == 9)
        {
            EnStr = 24;
            EnCon = 13;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 16;
        }

        if (EnLVL == 10)
        {
            EnStr = 26;
            EnCon = 15;
            EnDex = 0;
            EnInt = 0;
            EnAgi = 19;
        }
        DrawEnStarts();
    }



}
