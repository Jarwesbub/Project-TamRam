using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class XPControl : MonoBehaviour
{

    public int XPpoints;
    public int XPpointsDraw;
    public Text XPpointsTxt; // How much xp player get
    public Text XPpointsAllTxt; // Player's current xp ammount
    public GameObject LevelUPControl;
    public Text LvlUPTxt;

    public bool XPStart = false;
    public int PlayerLvlCheck;
    public int EnemyLvlCheck;

    public int XPNextLVL;

    public bool LevelNext = false;

    public int Check = 0;
    public bool EnemyDies = false;

    void Start()
    {
        XPStart = PersistentManagerScript.Instance.XPStart;
        XPpoints = PersistentManagerScript.Instance.XPpoints;

        //LevelUPControl.SetActive(false);
        EnemyDies = false;
    }



    void DrawXP()
    {
        PersistentManagerScript.Instance.XPpoints = XPpoints;


        XPpointsTxt.text = XPpointsDraw.ToString();
        XPpointsTxt.text = "+ " + XPpointsTxt.text + " XP";

        XPpointsAllTxt.text = XPpoints.ToString();
        XPpointsAllTxt.text = "[ " + XPpointsAllTxt.text + (" / ") + XPNextLVL.ToString() + " XP ]";

    }

    void LevelUP()
    {
        
        LevelUPControl.SetActive(true);
    }

    void XPLevelCheck()
    {
        if (PersistentManagerScript.Instance.Lvl >= PlayerLvlCheck + 1) // TESTING
        {
            LevelNext = true;
            
        }
        /*
        if (XPpoints >= 0)
        {
            PersistentManagerScript.Instance.Lvl = 1;
            PersistentManagerScript.Instance.LvlGet = true;
        }
        */
        

        //if (LevelNext == true)
        {

            if (XPpoints >= 200 && Check == 0)//200 original value
            {
                PersistentManagerScript.Instance.Lvl = 2;
                PersistentManagerScript.Instance.LvlGet = true;
                LevelNext = false;
                Check += 1;

            }

            if (XPpoints >= 400 && Check == 1) //400 original value
            {
                PersistentManagerScript.Instance.Lvl = 3;
                PersistentManagerScript.Instance.LvlGet = true;
                LevelNext = false;
                Check += 1;
            }

            if (XPpoints >= 800 && Check == 2) //800 original value
            {
                PersistentManagerScript.Instance.Lvl = 4;
                PersistentManagerScript.Instance.LvlGet = true;
                LevelNext = false;
                Check += 1;
            }

            if (XPpoints >= 1600 && Check == 3) //1600 original value
            {
                PersistentManagerScript.Instance.Lvl = 5;
                PersistentManagerScript.Instance.LvlGet = true;
                LevelNext = false;
                Check += 1;
            }

            if (XPpoints >= 3200 && Check == 4) //3200  original value
            {
                PersistentManagerScript.Instance.Lvl = 6;
                PersistentManagerScript.Instance.LvlGet = true;
                LevelNext = false;
                Check += 1;
            }

            if (XPpoints >= 6400 && Check == 5) //6400 original value
            {
                PersistentManagerScript.Instance.Lvl = 7;
                PersistentManagerScript.Instance.LvlGet = true;
                LevelNext = false;
                Check += 1;
            }

            if (XPpoints >= 12800 && Check == 6) //12800 original value
            {
                PersistentManagerScript.Instance.Lvl = 8;
                PersistentManagerScript.Instance.LvlGet = true;
                LevelNext = false;
                Check += 1;
            }

            if (XPpoints >= 25600 && Check == 7) //25600 original value
            {
                PersistentManagerScript.Instance.Lvl = 9;
                PersistentManagerScript.Instance.LvlGet = true;
                LevelNext = false;
                Check += 1;
            }

            if (XPpoints >= 51200 && Check == 8) //51200 original value
            {
                PersistentManagerScript.Instance.Lvl = 10;
                PersistentManagerScript.Instance.LvlGet = true;
                LevelNext = false;
                Check += 1;
            }

        }
        
        if (PersistentManagerScript.Instance.Lvl >= PlayerLvlCheck+1)
        {
            LevelUP();
            PlayerLvlCheck = PersistentManagerScript.Instance.Lvl;
        }
      
    
        

    }

    void NextLevelValue()
    {
       if (XPpoints >= 0 && XPpoints <= 198)
        {
            XPNextLVL = 200;
        }
        if (XPpoints >= 199 && XPpoints <= 399)
        {
            XPNextLVL = 400;
        }
        if (XPpoints >= 398 && XPpoints <= 799)
        {
            XPNextLVL = 800;
        }
        if (XPpoints >= 798 && XPpoints <= 1599)
        {
            XPNextLVL = 1600;
        }
        if (XPpoints >= 1598 && XPpoints <= 3199)
        {
            XPNextLVL = 3200;
        }
        if (XPpoints >= 3198 && XPpoints <= 6399)
        {
            XPNextLVL = 6400;
        }
        if (XPpoints >= 6398 && XPpoints <= 12799)
        {
            XPNextLVL = 12800;
        }
        if (XPpoints >= 12798 && XPpoints <= 25599)
        {
            XPNextLVL = 25600;
        }
        if (XPpoints >= 25598 && XPpoints <= 51199)
        {
            XPNextLVL = 51200;
        }
    }

    public void Update()
    {
        //XPpoints = PersistentManagerScript.Instance.XPpoints;
        PersistentManagerScript.Instance.XPNextLVL = XPNextLVL;

        NextLevelValue();


        if (PersistentManagerScript.Instance.XPScreen == 0)
        {
            EnemyDies = false;
            PersistentManagerScript.Instance.XPStart = true;
            PlayerLvlCheck = PersistentManagerScript.Instance.Lvl;
            EnemyLvlCheck = PersistentManagerScript.Instance.EnLVL;
        }


        if (PersistentManagerScript.Instance.XPScreen == 1 && PersistentManagerScript.Instance.XPStart == true) // Fightscreen XPScreen is activated
        {
            LevelUPControl.SetActive(false);


            if (EnemyDies == false)
            {
                if (EnemyLvlCheck == 1 && PersistentManagerScript.Instance.EnDies == 1)
                {
                    EnemyDies = true;
                    PersistentManagerScript.Instance.EnDies = 2;
                    PersistentManagerScript.Instance.XPpoints += 25;
                    XPpoints = PersistentManagerScript.Instance.XPpoints;
                    XPpointsDraw = 25;
                    DrawXP();
                    XPLevelCheck();

                    PersistentManagerScript.Instance.XPStart = false;
                }

                if (EnemyLvlCheck == 2 && PersistentManagerScript.Instance.EnDies == 1)
                {
                    EnemyDies = true;
                    PersistentManagerScript.Instance.EnDies = 2;
                    PersistentManagerScript.Instance.XPpoints += 50;
                    XPpoints = PersistentManagerScript.Instance.XPpoints;
                    XPpointsDraw = 50;
                    DrawXP();
                    XPLevelCheck();

                    PersistentManagerScript.Instance.XPStart = false;
                }

                if (EnemyLvlCheck == 3 && PersistentManagerScript.Instance.EnDies == 1)
                {
                    EnemyDies = true;
                    PersistentManagerScript.Instance.EnDies = 2;
                    PersistentManagerScript.Instance.XPpoints += 100;
                    XPpoints = PersistentManagerScript.Instance.XPpoints;
                    XPpointsDraw = 100;
                    DrawXP();
                    XPLevelCheck();

                    PersistentManagerScript.Instance.XPStart = false;
                }

                if (PersistentManagerScript.Instance.EnLvl == 4 && PersistentManagerScript.Instance.EnDies == 1)
                {
                    EnemyDies = true;
                    PersistentManagerScript.Instance.EnDies = 2;
                    PersistentManagerScript.Instance.XPpoints += 150;
                    XPpoints = PersistentManagerScript.Instance.XPpoints;
                    XPpointsDraw = 150;
                    DrawXP();
                    XPLevelCheck();

                    PersistentManagerScript.Instance.XPStart = false;
                }

                if (PersistentManagerScript.Instance.EnLvl == 5 && PersistentManagerScript.Instance.EnDies == 1)
                {
                    EnemyDies = true;
                    PersistentManagerScript.Instance.EnDies = 2;
                    PersistentManagerScript.Instance.XPpoints += 300;
                    XPpoints = PersistentManagerScript.Instance.XPpoints;
                    XPpointsDraw = 300;
                    DrawXP();
                    XPLevelCheck();

                    PersistentManagerScript.Instance.XPStart = false;
                }

                if (PersistentManagerScript.Instance.EnLvl == 6 && PersistentManagerScript.Instance.EnDies == 1)
                {
                    EnemyDies = true;
                    PersistentManagerScript.Instance.EnDies = 2;
                    PersistentManagerScript.Instance.XPpoints += 450;
                    XPpoints = PersistentManagerScript.Instance.XPpoints;
                    XPpointsDraw = 450;
                    DrawXP();
                    XPLevelCheck();

                    PersistentManagerScript.Instance.XPStart = false;
                }

                if (PersistentManagerScript.Instance.EnLvl == 7 && PersistentManagerScript.Instance.EnDies == 1)
                {
                    EnemyDies = true;
                    PersistentManagerScript.Instance.EnDies = 2;
                    PersistentManagerScript.Instance.XPpoints += 900;
                    XPpoints = PersistentManagerScript.Instance.XPpoints;
                    XPpointsDraw = 900;
                    DrawXP();
                    XPLevelCheck();

                    PersistentManagerScript.Instance.XPStart = false;
                }

                if (PersistentManagerScript.Instance.EnLvl == 8 && PersistentManagerScript.Instance.EnDies == 1)
                {
                    EnemyDies = true;
                    PersistentManagerScript.Instance.EnDies = 2;
                    PersistentManagerScript.Instance.XPpoints += 1350;
                    XPpoints = PersistentManagerScript.Instance.XPpoints;
                    XPpointsDraw = 1350;
                    DrawXP();
                    XPLevelCheck();

                    PersistentManagerScript.Instance.XPStart = false;
                }

                if (PersistentManagerScript.Instance.EnLvl == 9 && PersistentManagerScript.Instance.EnDies == 1)
                {
                    EnemyDies = true;
                    PersistentManagerScript.Instance.EnDies = 2;
                    PersistentManagerScript.Instance.XPpoints += 2700;
                    XPpoints = PersistentManagerScript.Instance.XPpoints;
                    XPpointsDraw = 2700;
                    DrawXP();
                    XPLevelCheck();

                    PersistentManagerScript.Instance.XPStart = false;
                }

                if (PersistentManagerScript.Instance.EnLvl == 10 && PersistentManagerScript.Instance.EnDies == 1)
                {
                    EnemyDies = true;
                    PersistentManagerScript.Instance.EnDies = 2;
                    PersistentManagerScript.Instance.XPpoints += 4050;
                    XPpoints = PersistentManagerScript.Instance.XPpoints;
                    XPpointsDraw = 4050;
                    DrawXP();
                    XPLevelCheck();

                    PersistentManagerScript.Instance.XPStart = false;
                }


            }


        }

    }

    }
