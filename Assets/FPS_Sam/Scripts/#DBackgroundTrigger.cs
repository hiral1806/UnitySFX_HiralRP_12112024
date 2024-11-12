using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tRIGGER : MonoBehaviour
{
    public AudioSource music;

    private void OnTriggerEnter(Collider other)
    {
        music.Pause();
    }


    private void OnTriggerExit(Collider other)
    {
        music.UnPause();
    }
}
