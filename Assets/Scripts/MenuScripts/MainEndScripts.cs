using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainEndScripts : MonoBehaviour
{
    public AudioSource ButtonPress;
    public AudioSource BackgroundMusic;



    public void GameResetRestart()
    {
        
        ButtonPress.Play();
        // Not working if starting game from GameOverScene screen!
        PersistentManagerScript.Instance.PlayerDies = false;
        PersistentManagerScript.Instance.WorldMapPos = 1;
        PersistentManagerScript.Instance.GameReset = true;
        Application.LoadLevel(0);
        //SceneManager.LoadScene("MainMenuScene");
    }
}
