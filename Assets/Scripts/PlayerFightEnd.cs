using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFightEnd : MonoBehaviour
{
    public GameObject parentObject;
    int childs;


    public void RunButton()
    {
        StartCoroutine(RunWait());


    }
    IEnumerator RunWait()
    {
        PersistentManagerScript.Instance.PlayerTurn = false;
        PersistentManagerScript.Instance.EnemyTurn = true;
        yield return new WaitForSeconds(1.5f);

        PersistentManagerScript.Instance.Run = true;

        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        PersistentManagerScript.Instance.StunActive = false;
        PersistentManagerScript.Instance.PoisonActive = false;
        PersistentManagerScript.Instance.ConfusionActive = false;
        PersistentManagerScript.Instance.WeakenActive = false;
        PersistentManagerScript.Instance.SlowActive = false;
        PersistentManagerScript.Instance.WeakenActive = false;
        PersistentManagerScript.Instance.BurnActive = false;

        PersistentManagerScript.Instance.EnDies = 2;
        PersistentManagerScript.Instance.XPScreen = 0;
        PersistentManagerScript.Instance.PlayerTurn = false;
        PersistentManagerScript.Instance.EnemyTurn = false;
        PersistentManagerScript.Instance.FightScreen = false;
        PersistentManagerScript.Instance.MapChange = true; // Spawner stops counting time otherwise

    }


    // Update is called once per frame
    void LateUpdate()
    {

        if (PersistentManagerScript.Instance.FightScreen == false)
        {
            PersistentManagerScript.Instance.PlayerCanMove = true;
            //Destroy(parentObject.transform.GetChild(0).gameObject);

            foreach (Transform child in transform)
            {
                GameObject.Destroy(child.gameObject);
            }

        }
    }




}
