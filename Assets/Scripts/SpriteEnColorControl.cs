using System.Collections;
using UnityEngine;

public class SpriteEnColorControl : MonoBehaviour
{
    public SpriteRenderer m_SpriteRenderer;
    public int Value;
    public int EnHealth;

    Color m_NewColor;

    float m_Red, m_Blue, m_Green;
    int FightStart = 0;
    bool FirstCheck = false;
    
    void Start()
    {
        FirstCheck = true;
        EnHealth = PersistentManagerScript.Instance.EnemyHealth;

        GetComponent<SpriteRenderer>();

        m_SpriteRenderer.color = new Color(255, 255, 255);

    }

    void Update()
    {
        if (FightStart == 1)
        {
            FightStart = 2;

            EnHealth = PersistentManagerScript.Instance.EnemyHealth;

            GetComponent<SpriteRenderer>();

            m_SpriteRenderer.color = new Color(255, 255, 255);


        }




        if (PersistentManagerScript.Instance.FightScreen == true)
        {
            if (FightStart == 2)
            {
                
                if (EnHealth - 20 >= PersistentManagerScript.Instance.EnemyHealth)
                {
                    EnHealth = PersistentManagerScript.Instance.EnemyHealth;

                    StartCoroutine(SpriteHyperDamage());
                }
                else if (EnHealth - 15 >= PersistentManagerScript.Instance.EnemyHealth)
                {
                    EnHealth = PersistentManagerScript.Instance.EnemyHealth;

                    StartCoroutine(SpriteSuperDamage());
                }


                else if (EnHealth - 1 >= PersistentManagerScript.Instance.EnemyHealth)
                {
                    EnHealth = PersistentManagerScript.Instance.EnemyHealth;
                    StartCoroutine(SpriteDamage());
                }

                else if (EnHealth + 1 <= PersistentManagerScript.Instance.EnemyHealth)
                {
                    EnHealth = PersistentManagerScript.Instance.EnemyHealth;
                    StartCoroutine(SpriteGetHP());
                }
            }


            if (FightStart == 0)
            {
                FightStart = 1;
            }

        }
    }

    IEnumerator SpriteDamage()
    {
        if (FirstCheck == false)
        {
            float time = 0.1f;
            m_SpriteRenderer.color = Color.red;
            yield return new WaitForSeconds(time);
            m_SpriteRenderer.color = new Color(255, 255, 255);
        }
        else
        {
            FirstCheck = false;
        }
    }

    IEnumerator SpriteSuperDamage()
    {
        if (FirstCheck == false)
        {
            float time = 0.1f;
        m_SpriteRenderer.color = Color.red;
        yield return new WaitForSeconds(time);
        m_SpriteRenderer.color = new Color(255, 255, 255);
        yield return new WaitForSeconds(time);
        m_SpriteRenderer.color = Color.red;
        yield return new WaitForSeconds(time);
        m_SpriteRenderer.color = new Color(255, 255, 255);
        }
        else
        {
            FirstCheck = false;
        }
    }

    IEnumerator SpriteHyperDamage()
    {
        if (FirstCheck == false)
        {
            float time = 0.1f;
        m_SpriteRenderer.color = Color.red;
        yield return new WaitForSeconds(time);
        m_SpriteRenderer.color = new Color(255, 255, 255);
        yield return new WaitForSeconds(time);
        m_SpriteRenderer.color = Color.red;
        yield return new WaitForSeconds(time);
        m_SpriteRenderer.color = new Color(255, 255, 255);
        yield return new WaitForSeconds(time);
        m_SpriteRenderer.color = Color.red;
        yield return new WaitForSeconds(time);
        m_SpriteRenderer.color = new Color(255, 255, 255);
        m_SpriteRenderer.color = Color.red;
        yield return new WaitForSeconds(time);
        m_SpriteRenderer.color = new Color(255, 255, 255);
    }
        else
        {
            FirstCheck = false;
        }
    }
    IEnumerator SpriteGetHP()
    {
        if (FirstCheck == false)
        {
            float time = 0.1f;
        m_SpriteRenderer.color = Color.green;
        yield return new WaitForSeconds(time);
        m_SpriteRenderer.color = new Color(255, 255, 255);
        }
        else
        {
            FirstCheck = false;
        }
    }


}