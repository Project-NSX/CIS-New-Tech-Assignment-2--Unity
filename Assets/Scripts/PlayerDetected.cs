using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetected : MonoBehaviour
{
    Animator anim;
    public GameObject enemy;


    // Start is called before the first frame update
    void Start()
    {
        anim = enemy.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            anim.SetTrigger("isWalking");
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
