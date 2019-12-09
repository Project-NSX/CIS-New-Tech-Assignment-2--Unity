using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public Transform grenade;
    public float timer = 3.0f;
    bool hasExploded = false;
    float countdown;

    public GameObject explosionEffect;

    // Start is called before the first frame update
    void Start()
    {
        countdown = timer;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && !hasExploded)
        {
            Explode();
            hasExploded = true;
        }
    }

    void Explode()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
