using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;

public class MenuManagerScript : MonoBehaviour
{

    public GameObject World1;
    public GameObject OpenWorld;
    public GameObject TamaMenu;
    public GameObject SkillPointsMenu;
    public GameObject CanvasStats;
    public GameObject FightScreen;
    public GameObject CanvasFight;
    public GameObject MainCamera; // When moving to gameplay screen -> disable "Statscamera"
    public GameObject PlayerMove;
    public GameObject PlayerFight;
    public GameObject EnLVLControl;

    public GameObject GoMenu;

    public GameObject TamaPlayer;
    public GameObject SleepTextObj;
    public GameObject MapDisplay;

    public AudioSource ScreenChange;
    public AudioSource Buttons1;
    public AudioSource SPButton;

    bool MapActive = false;

    public void GoToWorld1()
    {

        World1.SetActive(true);
        OpenWorld.SetActive(true);
        TamaMenu.SetActive(false);
        SkillPointsMenu.SetActive(false);
        MainCamera.SetActive(false);
        CanvasStats.SetActive(false);

        PlayerMove.SetActive(true);
        PlayerFight.SetActive(false);
        ScreenChange.Play();

        //SceneManager.LoadScene("TamaMenuScene");
        //PersistentManagerScript.Instance.Str++; //test add 1

    }
    public void GoToTamaMenu()
    {
        if (PersistentManagerScript.Instance.PlayerCanMove == true)
        {
            TamaMenu.SetActive(true);
            World1.SetActive(false);
            OpenWorld.SetActive(false);
            SkillPointsMenu.SetActive(false);
            MainCamera.SetActive(true);
            CanvasStats.SetActive(true);
            ScreenChange.Play();
        }
        //SceneManager.LoadScene("World1Scene");
        //PersistentManagerScript.Instance.Str++; //test add 1

    }
    public void GoToSkillPoints()
    {

        SkillPointsMenu.SetActive(true);
        World1.SetActive(false);
        OpenWorld.SetActive(false);
        TamaMenu.SetActive(false);
        MainCamera.SetActive(true);
        CanvasStats.SetActive(true);
        SPButton.Play();
    }

    public void ShowMap()
    {
        if (MapActive == false)
        {
            ScreenChange.Play();
            MapDisplay.SetActive(true);
            MapActive = true;
        }
        else
        {
            ScreenChange.Play();
            MapDisplay.SetActive(false);
            MapActive = false;
        }


    }



    public void AddHealth() // Particle system handles this now
    {
        PersistentManagerScript.Instance.PlayerHealth = PersistentManagerScript.Instance.PlayerMaxHealth;
        Buttons1.Play();
    }

    public void SleepButton()
    {
        StartCoroutine(Sleep());
        PersistentManagerScript.Instance.PlayerMana = PersistentManagerScript.Instance.maxMana;
        Buttons1.Play();

    }
    IEnumerator Sleep()
    {
        TamaPlayer.SetActive(false);
        SleepTextObj.SetActive(true);

        yield return new WaitForSeconds(3f);

        SleepTextObj.SetActive(false);
        TamaPlayer.SetActive(true);



    }

    void Update()
    {

        if (PersistentManagerScript.Instance.FightScreen == true)
        {

            World1.SetActive(true);
            OpenWorld.SetActive(false);
            TamaMenu.SetActive(false);
            SkillPointsMenu.SetActive(false);
            CanvasStats.SetActive(false);
            PlayerMove.SetActive(false);
            PlayerFight.SetActive(true);
            GoMenu.SetActive(false);

            //MainCamera.SetActive(true);
            FightScreen.SetActive(true);
            CanvasFight.SetActive(true);
            EnLVLControl.SetActive(true);
        }

        else
        {

            GoMenu.SetActive(true);
            OpenWorld.SetActive(true);
            PlayerMove.SetActive(true);
            PlayerFight.SetActive(false);
            CanvasFight.SetActive(false);
            FightScreen.SetActive(false);
            EnLVLControl.SetActive(false);
        }
    }
}

