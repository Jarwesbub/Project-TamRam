using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TamaBackground : MonoBehaviour
{
    public GameObject Map1;
    public GameObject Map2;
    public GameObject Map3;
    public GameObject Map4;
    public GameObject Map5;

    // Update is called once per frame
    void Update()
    {
        if (PersistentManagerScript.Instance.WorldMapPos == 0 || PersistentManagerScript.Instance.WorldMapPos == 1)
        {
            Map1.SetActive(true);
            Map2.SetActive(false);
            Map3.SetActive(false);
            Map4.SetActive(false);
            Map5.SetActive(false);

        }

        if (PersistentManagerScript.Instance.WorldMapPos == 2)
        {
            Map1.SetActive(false);
            Map2.SetActive(true);
            Map3.SetActive(false);
            Map4.SetActive(false);
            Map5.SetActive(false);

        }

        if (PersistentManagerScript.Instance.WorldMapPos == 3)
        {
            Map1.SetActive(false);
            Map2.SetActive(false);
            Map3.SetActive(true);
            Map4.SetActive(false);
            Map5.SetActive(false);

        }

        if (PersistentManagerScript.Instance.WorldMapPos == 4)
        {
            Map1.SetActive(false);
            Map2.SetActive(false);
            Map3.SetActive(false);
            Map4.SetActive(true);
            Map5.SetActive(false);

        }

        if (PersistentManagerScript.Instance.WorldMapPos == 5)
        {
            Map1.SetActive(false);
            Map2.SetActive(false);
            Map3.SetActive(false);
            Map4.SetActive(false);
            Map5.SetActive(true);

        }
    }
}
