using UnityEngine;

public class ScreenChange : MonoBehaviour
{
    public Animator animator;
    public GameObject WhiteScreen;


    void Start()
    {
        WhiteScreen.SetActive(false);

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("l"))
        {

            WhiteScreen.SetActive(true);
            FadeToLevel();

        }

        if (PersistentManagerScript.Instance.FightTransition == true)
        {
            PersistentManagerScript.Instance.FightTransition = false;
            PersistentManagerScript.Instance.PlayerCanMove = false;
            WhiteScreen.SetActive(true);
            FadeToLevel();
        }


    }

    public void FadeToLevel ()
    {
        //anim.Play();
        
        animator.SetTrigger("FadeIn");

    }

    public void FadeChangeScreen()
    {

        PersistentManagerScript.Instance.XPScreen = 0;
        PersistentManagerScript.Instance.FightScreen = true;

        PersistentManagerScript.Instance.EnDies = 0;

        PersistentManagerScript.Instance.IsCritical = false;
        PersistentManagerScript.Instance.EnemyTurn = false;
        PersistentManagerScript.Instance.PlayerTurn = false;


    }


    public void OnFadeComplete()
    {
        WhiteScreen.SetActive(false);
    }



}
