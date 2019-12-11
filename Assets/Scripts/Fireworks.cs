using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireworks : MonoBehaviour
{
    public GameObject fireworks1;
    public GameObject fireworks2;
    public GameObject fireworks3;
    public GameObject fireworks4;
    public GameObject fireworks5;
    public GameObject fireworks6;
    public GameObject fireworks7;
    public GameObject fireworks8;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Ball")
        {
            FindObjectOfType<AudioManager>().Play("Fireworks1");
            FindObjectOfType<AudioManager>().Play("Fireworks2");
            FindObjectOfType<AudioManager>().Play("Fireworks3");
            FindObjectOfType<AudioManager>().Play("Fireworks4");
            Debug.Log("Fireworks!!!");
            fireworks1.GetComponent<ParticleSystem>().Play();
            fireworks2.GetComponent<ParticleSystem>().Play();
            fireworks3.GetComponent<ParticleSystem>().Play();
            fireworks4.GetComponent<ParticleSystem>().Play();
            fireworks5.GetComponent<ParticleSystem>().Play();
            fireworks6.GetComponent<ParticleSystem>().Play();
            fireworks7.GetComponent<ParticleSystem>().Play();
            fireworks8.GetComponent<ParticleSystem>().Play();
            
        }

    }
}
