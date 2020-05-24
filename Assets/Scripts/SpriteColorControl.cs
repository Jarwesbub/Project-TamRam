using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class SpriteColorControl : MonoBehaviour
{
    public SpriteRenderer m_SpriteRenderer;
    public int Value;
    public int Health;

    Color m_NewColor;

    float m_Red, m_Blue, m_Green;


    void Start()
    {
        Health = PersistentManagerScript.Instance.PlayerHealth;

        GetComponent<SpriteRenderer>();

        m_SpriteRenderer.color = new Color(255, 255, 255);

    }

    void Update()
    {

        if (Health-1 >= PersistentManagerScript.Instance.PlayerHealth)
        {
            Health = PersistentManagerScript.Instance.PlayerHealth;
            StartCoroutine(SpriteDamage());
        }

        if (Health + 1 <= PersistentManagerScript.Instance.PlayerHealth)
        {
            Health = PersistentManagerScript.Instance.PlayerHealth;
            StartCoroutine(SpriteGetHP());
        }

        if (PersistentManagerScript.Instance.DefenseActiveColor == true)
        {
            PersistentManagerScript.Instance.DefenseActiveColor = false;
            StartCoroutine(Class1DefenseCounter());
        }

    }

    IEnumerator Class1DefenseCounter()
    {
        float time = 2f;
        m_SpriteRenderer.color = Color.grey;
        yield return new WaitForSeconds(time);

        m_SpriteRenderer.color = new Color(255, 255, 255);

    }


    IEnumerator SpriteDamage()
    {
        float time = 0.1f;
            m_SpriteRenderer.color = Color.red;
            yield return new WaitForSeconds(time);
            m_SpriteRenderer.color = new Color(255, 255, 255);

    }

    IEnumerator SpriteGetHP()
    {
        float time = 0.1f;
        m_SpriteRenderer.color = Color.green;
        yield return new WaitForSeconds(time);
        m_SpriteRenderer.color = new Color(255, 255, 255);

    }

    /*
void OnGUI()
{

    //Use the Label to identify the Slider
    GUI.Label(new Rect(0, 30, 50, 30), "Red: ");

    m_Red = GUI.HorizontalSlider(new Rect(35, 25, 200, 30), m_Red, 0, 1);


    GUI.Label(new Rect(0, 70, 50, 30), "Green: ");
    m_Green = GUI.HorizontalSlider(new Rect(35, 60, 200, 30), m_Green, 0, 1);

    GUI.Label(new Rect(0, 105, 50, 30), "Blue: ");
    m_Blue = GUI.HorizontalSlider(new Rect(35, 95, 200, 30), m_Blue, 0, 1);

    //Set the Color to the values gained from the Sliders
    //m_NewColor = new Color(m_Red, m_Green, m_Blue);
    m_NewColor = new Color(255, 0, 0);
    m_NewColor = new Color(255, 255, 255);

    //Set the SpriteRenderer to the Color defined by the Sliders
    //m_SpriteRenderer.color = m_NewColor;

}
*/

}