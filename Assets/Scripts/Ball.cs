using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
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

        if (other.tag == "RightLeg")
        {
            FindObjectOfType<AudioManager>().Play("ball");
            // how much the character should be knocked back
            var magnitude = 1000;
            // calculate force vector
            var force = transform.forward;
            // normalize force vector to get direction only and trim magnitude
            force.Normalize();
            gameObject.GetComponent<Rigidbody>().AddForce(force * magnitude);
        }

    }
}
