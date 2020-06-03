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
    int EnWis;

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
        if (PersistentManagerScript.Instance.WorldMapPos != 5)
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
    else if (PersistentManagerScript.Instance.WorldMapPos == 5) // Volcanic are enemy level always 11-15
        {
            EnLVL = Random.Range(11, 16); // Level 15 is extra for testing

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
            EnDex = 7;
            EnInt = 3;
            EnAgi = 6;
            EnCon = 3;
            EnWis = 2;
        }

        if (EnLVL == 2)
        {
            EnStr = 13;
            EnDex = 8;
            EnInt = 4;
            EnAgi = 7;
            EnCon = 4;
            EnWis = 3;
        }

        if (EnLVL == 3)
        {
            EnStr = 13;
            EnDex = 9;
            EnInt = 5;
            EnAgi = 8;
            EnCon = 5;
            EnWis = 4;
        }

        if (EnLVL == 4)
        {
            EnStr = 14;
            EnDex = 10;
            EnInt = 6;
            EnAgi = 9;
            EnCon = 6;
            EnWis = 5;
        }

        if (EnLVL == 5)
        {
            EnStr = 15;
            EnDex = 11;
            EnInt = 7;
            EnAgi = 10;
            EnCon = 7;
            EnWis = 6;
        }

        if (EnLVL == 6)
        {
            EnStr = 16;
            EnDex = 12;
            EnInt = 8;
            EnAgi = 11;
            EnCon = 8;
            EnWis = 7;
        }

        if (EnLVL == 7)
        {
            EnStr = 17;
            EnDex = 13;
            EnInt = 9;
            EnAgi = 12;
            EnCon = 9;
            EnWis = 8;
        }

        if (EnLVL == 8)
        {
            EnStr = 18;
            EnDex = 14;
            EnInt = 10;
            EnAgi = 13;
            EnCon = 10;
            EnWis = 9;
        }

        if (EnLVL == 9)
        {
            EnStr = 19;
            EnDex = 15;
            EnInt = 11;
            EnAgi = 14;
            EnCon = 11;
            EnWis = 10;
        }

        if (EnLVL == 10)
        {
            EnStr = 20;
            EnDex = 16;
            EnInt = 12;
            EnAgi = 15;
            EnCon = 12;
            EnWis = 11;
        }

        if (EnLVL == 11)
        {
            EnStr = 21;
            EnDex = 17;
            EnInt = 13;
            EnAgi = 16;
            EnCon = 12; // 13
            EnWis = 12;
        }

        if (EnLVL == 12)
        {
            EnStr = 22;
            EnDex = 18;
            EnInt = 14;
            EnAgi = 17;
            EnCon = 13; // 14
            EnWis = 12;
        }

        if (EnLVL == 13)
        {
            EnStr = 23;
            EnDex = 19;
            EnInt = 15;
            EnAgi = 18;
            EnCon = 13; // 15
            EnWis = 13;
        }

        if (EnLVL == 14)
        {
            EnStr = 24;
            EnDex = 20;
            EnInt = 16;
            EnAgi = 19;
            EnCon = 14; // 16
            EnWis = 14;
        }
        ////////////////////////////
        if (EnLVL == 15)
        {
            EnStr = 25;
            EnDex = 21;
            EnInt = 17;
            EnAgi = 20;
            EnCon = 14; // 17
            EnWis = 15;
        }
        DrawEnStarts();
    }

    void EnemyClass2() /////////////////////////////////
    {
        DrawEnStarts();

        if (EnLVL == 1)
        {
            EnStr = 3;
            EnDex = 13;
            EnInt = 7;
            EnAgi = 8;
            EnCon = 3;
            EnWis = 2;
        }

        if (EnLVL == 2)
        {
            EnStr = 4;
            EnDex = 13;
            EnInt = 8;
            EnAgi = 9;
            EnCon = 4;
            EnWis = 3;
        }

        if (EnLVL == 3)
        {
            EnStr = 5;
            EnDex = 13;
            EnInt = 9;
            EnAgi = 10;
            EnCon = 5;
            EnWis = 4;
        }

        if (EnLVL == 4)
        {
            EnStr = 6;
            EnDex = 14;
            EnInt = 10;
            EnAgi = 11;
            EnCon = 6;
            EnWis = 5;
        }

        if (EnLVL == 5)
        {
            EnStr = 7;
            EnDex = 15;
            EnInt = 11;
            EnAgi = 12;
            EnCon = 7;
            EnWis = 6;
        }

        if (EnLVL == 6)
        {
            EnStr = 8;
            EnDex = 16;
            EnInt = 12;
            EnAgi = 13;
            EnCon = 8;
            EnWis = 7;
        }

        if (EnLVL == 7)
        {
            EnStr = 9;
            EnDex = 17;
            EnInt = 13;
            EnAgi = 14;
            EnCon = 9;
            EnWis = 8;
        }

        if (EnLVL == 8)
        {
            EnStr = 10;
            EnDex = 18;
            EnInt = 14;
            EnAgi = 15;
            EnCon = 10;
            EnWis = 9;
        }

        if (EnLVL == 9)
        {
            EnStr = 11;
            EnDex = 19;
            EnInt = 15;
            EnAgi = 16;
            EnCon = 11;
            EnWis = 10;
        }

        if (EnLVL == 10)
        {
            EnStr = 12;
            EnDex = 20;
            EnInt = 16;
            EnAgi = 17;
            EnCon = 12;
            EnWis = 11;
        }

        if (EnLVL == 11)
        {
            EnStr = 13;
            EnDex = 21;
            EnInt = 17;
            EnAgi = 18;
            EnCon = 12; // 13
            EnWis = 12;
        }

        if (EnLVL == 12)
        {
            EnStr = 14;
            EnDex = 22;
            EnInt = 18;
            EnAgi = 19;
            EnCon = 12; // 14
            EnWis = 12;
        }

        if (EnLVL == 13)
        {
            EnStr = 15;
            EnDex = 23;
            EnInt = 19;
            EnAgi = 20;
            EnCon = 12; // 15
            EnWis = 13;
        }

        if (EnLVL == 14)
        {
            EnStr = 16;
            EnDex = 24;
            EnInt = 20;
            EnAgi = 21;
            EnCon = 13; // 16
            EnWis = 14;
        }
        ////////////////////////////
        if (EnLVL == 15)
        {
            EnStr = 17;
            EnDex = 25;
            EnInt = 21;
            EnAgi = 22;
            EnCon = 13; // 17
            EnWis = 15;
        }

        DrawEnStarts();
    }

    void EnemyClass3() /////////////////////////////////
    {
        DrawEnStarts();

        if (EnLVL == 1)
        {
            EnStr = 7;
            EnDex = 3;
            EnInt = 13;
            EnAgi = 5;
            EnCon = 3;
            EnWis = 2;
        }

        if (EnLVL == 2)
        {
            EnStr = 8;
            EnDex = 4;
            EnInt = 13;
            EnAgi = 6;
            EnCon = 4;
            EnWis = 3;
        }

        if (EnLVL == 3)
        {
            EnStr = 9;
            EnDex = 5;
            EnInt = 13;
            EnAgi = 7;
            EnCon = 5;
            EnWis = 4;
        }

        if (EnLVL == 4)
        {
            EnStr = 10;
            EnDex = 6;
            EnInt = 14;
            EnAgi = 8;
            EnCon = 6;
            EnWis = 5;
        }

        if (EnLVL == 5)
        {
            EnStr = 11;
            EnDex = 7;
            EnInt = 15;
            EnAgi = 9;
            EnCon = 7;
            EnWis = 6;
        }

        if (EnLVL == 6)
        {
            EnStr = 12;
            EnDex = 8;
            EnInt = 16;
            EnAgi = 10;
            EnCon = 8;
            EnWis = 7;
        }

        if (EnLVL == 7)
        {
            EnStr = 13;
            EnDex = 9;
            EnInt = 17;
            EnAgi = 11;
            EnCon = 9;
            EnWis = 8;
        }

        if (EnLVL == 8)
        {
            EnStr = 14;
            EnDex = 10;
            EnInt = 18;
            EnAgi = 12;
            EnCon = 10;
            EnWis = 9;
        }

        if (EnLVL == 9)
        {
            EnStr = 15;
            EnDex = 11;
            EnInt = 19;
            EnAgi = 13;
            EnCon = 11;
            EnWis = 10;
        }

        if (EnLVL == 10)
        {
            EnStr = 16;
            EnDex = 12;
            EnInt = 20;
            EnAgi = 14;
            EnCon = 12;
            EnWis = 11;
        }

        if (EnLVL == 11)
        {
            EnStr = 17;
            EnDex = 13;
            EnInt = 21;
            EnAgi = 15;
            EnCon = 12; // 13
            EnWis = 12;
        }

        if (EnLVL == 12)
        {
            EnStr = 18;
            EnDex = 14;
            EnInt = 22;
            EnAgi = 16;
            EnCon = 12; // 14
            EnWis = 13;
        }

        if (EnLVL == 13)
        {
            EnStr = 19;
            EnDex = 15;
            EnInt = 23;
            EnAgi = 17;
            EnCon = 12; // 15
            EnWis = 14;
        }

        if (EnLVL == 14)
        {
            EnStr = 20;
            EnDex = 16;
            EnInt = 24;
            EnAgi = 18;
            EnCon = 13; // 16
            EnWis = 15;
        }
        ////////////////////////////
        if (EnLVL == 15)
        {
            EnStr = 21;
            EnDex = 17;
            EnInt = 25;
            EnAgi = 19;
            EnCon = 13; // 17
            EnWis = 16;
        }
        DrawEnStarts();
    }



}
