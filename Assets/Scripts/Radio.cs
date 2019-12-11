using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{

    public GameObject fireworks1;

    void PlayMusic()
    {
        fireworks1.GetComponent<ParticleSystem>().Play();
        FindObjectOfType<AudioManager>().Play("Click");
        FindObjectOfType<AudioManager>().Stop("Theme");
        FindObjectOfType<AudioManager>().Play("Music");
    }
}
