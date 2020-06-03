using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class FightCameraControl : MonoBehaviour
{
    public Transform[] views;
    public float transitionSpeed;
    Transform currentView;
    public GameObject FightCamera;

    // Start is called before the first frame update
    void Start()
    {
        /*
        transform.position = new Vector3(0, 0, 2);
        currentView = views[1];
        */
    }

    void OnEnable()
    {
        //PersistentManagerScript.Instance.EnemyHealth = 5; // If enemy health is 0 -> Fight wont start

        transform.position = new Vector3(-10, 30, 20); // -1, 3, -9 original
        currentView = views[0];
    }


    void Update()
    {

        /*
        if (PersistentManagerScript.Instance.FightScreen == true)
        {

                currentView = views[0];
                currentView = views[1];


        }
        else
        {
            currentView = views[0];
        }
        */
        /*
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentView = views [1];

        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            currentView = views [2];
        }
        */

    }



    // Update is called once per frame
    void LateUpdate()
    {
        //Lerp position
        transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);

        /*
            Vector3 currentAngle = new Vector3(
         Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.transform.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed),
         Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.transform.rotation.eulerAngles.y, Time.deltaTime * transitionSpeed),
           Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.transform.rotation.eulerAngles.z, Time.deltaTime * transitionSpeed));

        transform.eulerAngles = currentAngle;
        */
    }
}
