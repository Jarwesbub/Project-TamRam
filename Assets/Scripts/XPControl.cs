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

    public int XPNextLVL;

    void Start()
    {
        XPStart = PersistentManagerScript.Instance.XPStart;
        XPpoints = PersistentManagerScript.Instance.XPpoints;

        //LevelUPControl.SetActive(false);

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
        /*
        if (XPpoints >= 0)
        {
            PersistentManagerScript.Instance.Lvl = 1;
            PersistentManagerScript.Instance.LvlGet = true;
        }
        */

        if (XPpoints >= 200)//200 original value
        {
            PersistentManagerScript.Instance.Lvl = 2;
            PersistentManagerScript.Instance.LvlGet = true;

        }

        if (XPpoints >= 400) //400 original value
        {
            PersistentManagerScript.Instance.Lvl = 3;
            PersistentManagerScript.Instance.LvlGet = true;
        }

        if (XPpoints >= 800) //800 original value
        {
            PersistentManagerScript.Instance.Lvl = 4;
            PersistentManagerScript.Instance.LvlGet = true;
        }

        if (XPpoints >= 1600) //1600 original value
        {
            PersistentManagerScript.Instance.Lvl = 5;
            PersistentManagerScript.Instance.LvlGet = true;
        }

        if (XPpoints >= 3200) //3200  original value
        {
            PersistentManagerScript.Instance.Lvl = 6;
            PersistentManagerScript.Instance.LvlGet = true;
        }

        if (XPpoints >= 6400) //6400 original value
        {
            PersistentManagerScript.Instance.Lvl = 7;
            PersistentManagerScript.Instance.LvlGet = true;
        }

        if (XPpoints >= 12800) //12800 original value
        {
            PersistentManagerScript.Instance.Lvl = 8;
            PersistentManagerScript.Instance.LvlGet = true;
        }

        if (XPpoints >= 25600) //25600 original value
        {
            PersistentManagerScript.Instance.Lvl = 9;
            PersistentManagerScript.Instance.LvlGet = true;
        }

        if (XPpoints >= 51200) //51200 original value
        {
            PersistentManagerScript.Instance.Lvl = 10;
            PersistentManagerScript.Instance.LvlGet = true;
        }

       
        if (PersistentManagerScript.Instance.Lvl >= PlayerLvlCheck+1)
        {
            LevelUP();
        }
        

        

    }

    void NextLevelValue()
    {
       if (XPpoints >= 0 && XPpoints <= 201)
        {
            XPNextLVL = 200;
        }
        if (XPpoints >= 201 && XPpoints <= 401)
        {
            XPNextLVL = 400;
        }
        if (XPpoints >= 401 && XPpoints <= 801)
        {
            XPNextLVL = 800;
        }
        if (XPpoints >= 801 && XPpoints <= 1601)
        {
            XPNextLVL = 1600;
        }
        if (XPpoints >= 1601 && XPpoints <= 3201)
        {
            XPNextLVL = 3200;
        }
        if (XPpoints >= 3201 && XPpoints <= 6401)
        {
            XPNextLVL = 6400;
        }
        if (XPpoints >= 6401 && XPpoints <= 12801)
        {
            XPNextLVL = 12800;
        }
        if (XPpoints >= 12801 && XPpoints <= 25601)
        {
            XPNextLVL = 25600;
        }
        if (XPpoints >= 25601 && XPpoints <= 51201)
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
            PersistentManagerScript.Instance.XPStart = true;
            PlayerLvlCheck = PersistentManagerScript.Instance.Lvl;
        }


            if (PersistentManagerScript.Instance.XPScreen == 1 && PersistentManagerScript.Instance.XPStart == true) // Fightscreen XPScreen is activated
        {
            LevelUPControl.SetActive(false);
            


            if (PersistentManagerScript.Instance.EnLvl == 1 && PersistentManagerScript.Instance.EnDies == 1)
            {
                PersistentManagerScript.Instance.EnDies = 2;
                PersistentManagerScript.Instance.XPpoints += 25;
                XPpoints = PersistentManagerScript.Instance.XPpoints;
                XPpointsDraw = 25;
                DrawXP();
                XPLevelCheck();

                PersistentManagerScript.Instance.XPStart = false;
            }

            if (PersistentManagerScript.Instance.EnLvl == 2 && PersistentManagerScript.Instance.EnDies == 1)
            {
                PersistentManagerScript.Instance.EnDies = 2;
                PersistentManagerScript.Instance.XPpoints += 50;
                XPpoints = PersistentManagerScript.Instance.XPpoints;
                XPpointsDraw = 50;
                DrawXP();
                XPLevelCheck();

                PersistentManagerScript.Instance.XPStart = false;
            }

            if (PersistentManagerScript.Instance.EnLvl == 3 && PersistentManagerScript.Instance.EnDies == 1)
            {
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
