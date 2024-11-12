using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript3 : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource music;

    private void OnTriggerEnter(Collider other)
    {
        music.UnPause();
    }


    private void OnTriggerExit(Collider other)
    {
        music.Pause();
    }
}

        
  
