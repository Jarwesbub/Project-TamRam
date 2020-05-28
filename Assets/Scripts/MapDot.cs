using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDot : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (PersistentManagerScript.Instance.WorldMapPos == 0 || PersistentManagerScript.Instance.WorldMapPos == 1)
        {
            transform.localPosition = new Vector2(-5.1f, 24.7f); // 1
        }
        if (PersistentManagerScript.Instance.WorldMapPos == 2)
        {
            transform.localPosition = new Vector2(-132.9f, 137.4f); // 2
        }
        if (PersistentManagerScript.Instance.WorldMapPos == 3)
        {
            transform.localPosition = new Vector2(-139.6f, -102.9f); // 3
        }
        if (PersistentManagerScript.Instance.WorldMapPos == 4)
        {
            transform.localPosition = new Vector2(119.5f, 138.5f); // 4
        }
        if (PersistentManagerScript.Instance.WorldMapPos == 5)
        {
            transform.localPosition = new Vector2(94.9f, -92.9f); // 5
        }
    }
}
//transform.position = new Vector2(-0.3f, 0.4f); // 1

//transform.position = new Vector2(-2f, 2f); // 2

//transform.position = new Vector2(-2f, -1.4f); // 3

// transform.position = new Vector2(1.4f, 2f); // 4

//transform.position = new Vector2(1.4f, -1.4f); // 5