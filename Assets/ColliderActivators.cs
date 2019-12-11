using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderActivators : MonoBehaviour
{
    GameObject[] leg;

    GameObject[] arm;

    void ActivateLeg()
    {
        leg = GameObject.FindGameObjectsWithTag("RightLeg");

        foreach (GameObject i in leg)
        {
            i.GetComponent<CapsuleCollider>().enabled = true;

        }
    }

    void DeactivateLeg()
    {
        foreach (GameObject i in leg)
        {
            i.GetComponent<CapsuleCollider>().enabled = false;
        }
    }

    void ActivateArm()
    {
        arm = GameObject.FindGameObjectsWithTag("LeftHand");

        foreach (GameObject i in arm)
        {
            i.GetComponent<CapsuleCollider>().enabled = true;

        }
    }

    void DeactivateArm()
    {
        foreach (GameObject i in arm)
        {
            i.GetComponent<CapsuleCollider>().enabled = false;
        }
    }
}
