using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterVolume : MonoBehaviour
{
    [Range(0.0f, 1.0f)]
    [SerializeField]

    public float masterVolume = 1.0f;


    void Update()
    {
        AudioListener.volume = masterVolume;
    }
}
