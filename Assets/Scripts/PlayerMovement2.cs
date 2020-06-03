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

    bool MoveCheck = true;

    void OnEnable()
    {
        StartCoroutine(WaitMove());
    }


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

        if (PersistentManagerScript.Instance.PlayerCanMove == true && MoveCheck == false)
        {
            gameObject.tag = "PlayerWait";
            StartCoroutine(WaitMove());

        }

    }

    void FixedUpdate()
    {
        if (PersistentManagerScript.Instance.PlayerCanMove == true && MoveCheck == true)
        {
            movement = new Vector2(moveHorizontal, moveVertical);
            rb.velocity = movement * moveSpeed;
        }
        if (PersistentManagerScript.Instance.PlayerCanMove == false)
        {
            gameObject.tag = "PlayerWait";
            MoveCheck = false;
            rb.velocity = movement * moveSpeed * 0f;

        }
        /*
        if (PersistentManagerScript.Instance.PlayerCanMove == true && MoveCheck == false)
        {
            gameObject.tag = "PlayerWait";
            StartCoroutine(WaitMove());

        }
        */
    }

    IEnumerator WaitMove()
    {
        float Time = 2f;
        //yield return new WaitForSeconds(0.1f); // 0.1
        MoveCheck = true;
        yield return new WaitForSeconds(Time);

        gameObject.tag = "Player";
    }




}



