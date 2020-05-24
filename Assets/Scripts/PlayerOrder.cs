using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOrder : MonoBehaviour
{
    public int sortingOrder = 10;
    public SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        sortingOrder = 35;
        sprite.sortingOrder = sortingOrder;

    }

    void OnTriggerExit2D(Collider2D other)
    {
        sortingOrder = 10;
        sprite.sortingOrder = sortingOrder;

    }
}
