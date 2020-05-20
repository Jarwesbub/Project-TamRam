using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCollider : MonoBehaviour
{
    public GameObject GrassBackground;
    public GameObject OasisBackground;
    public GameObject TundraBackground;
    public GameObject VolcanicBackground;



    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "EnterMap2")
        {
            PersistentManagerScript.Instance.WorldMapPos = 2;
            PersistentManagerScript.Instance.MapChange = true;
            GrassBackground.SetActive(true);
            OasisBackground.SetActive(false);
            TundraBackground.SetActive(false);
            VolcanicBackground.SetActive(false);
        }

        if (collider.gameObject.name == "EnterMap3")
        {
            PersistentManagerScript.Instance.WorldMapPos = 3;
            PersistentManagerScript.Instance.MapChange = true;
            GrassBackground.SetActive(false);
            OasisBackground.SetActive(true);
            TundraBackground.SetActive(false);
            VolcanicBackground.SetActive(false);
        }

        if (collider.gameObject.name == "EnterMap4")
        {
            PersistentManagerScript.Instance.WorldMapPos = 4;
            PersistentManagerScript.Instance.MapChange = true;
            GrassBackground.SetActive(false);
            OasisBackground.SetActive(false);
            TundraBackground.SetActive(true);
            VolcanicBackground.SetActive(false);
        }

        if (collider.gameObject.name == "EnterMap5")
        {
            PersistentManagerScript.Instance.WorldMapPos = 5;
            PersistentManagerScript.Instance.MapChange = true;
            GrassBackground.SetActive(false);
            OasisBackground.SetActive(false);
            TundraBackground.SetActive(false);
            VolcanicBackground.SetActive(true);
        }


    }


}
