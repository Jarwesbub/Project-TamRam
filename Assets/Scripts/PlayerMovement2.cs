using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public float moveHorizontal;
    public float moveVertical;

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    private Vector2 movement;


    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal") * moveSpeed;
        moveVertical = Input.GetAxis("Vertical") * moveSpeed;

        Vector3 characterScale = transform.localScale;

        if(Input.GetAxis("Horizontal") < 0)
        {
            characterScale.x = -1;
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = 1;
        }
        transform.localScale = characterScale;

    }

    void FixedUpdate()
    {
        if (PersistentManagerScript.Instance.PlayerCanMove == true)
        {
            movement = new Vector2(moveHorizontal, moveVertical);
            rb.velocity = movement * moveSpeed;
        }
        else
        {
            rb.velocity = movement * moveSpeed * 0f;

        }
    }


}



