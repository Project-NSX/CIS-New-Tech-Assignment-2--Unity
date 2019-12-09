using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    // Game object used to store the player
    GameObject player;
    //Initialise animator
    Animator anim;

    // Ragdoll Colliders
    public Collider MainCollider;
    public Collider[] AllColliders;
    public UnityEngine.AI.NavMeshAgent enemyAgent;

    private void Awake()
    {
        MainCollider = GetComponent<Collider>();
        AllColliders = GetComponentsInChildren<Collider>();

        // Get player using their tag
        player = GameObject.FindGameObjectWithTag("Player");
        // Get animator
        anim = GetComponent<Animator>();
        enemyAgent = anim.GetComponent<UnityEngine.AI.NavMeshAgent>();

    }



    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 1)
        {
            anim.SetBool("isAttacking", true);
        }
        else
        {
            anim.SetBool("isAttacking", false);
        }
    }

    // Method called from NPCBaseFSM
    public GameObject GetPlayer()
    {
        // Return the gameobject of the player (Set below via tag)
        return player;
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "RightLeg" && this.tag == "Enemy" || other.tag == "LeftHand" && this.tag == "Enemy")
        {
            foreach (var col in AllColliders)
            {
                col.enabled = true;
            }

            GetComponent<CapsuleCollider>().enabled = false;

            GetComponent<Rigidbody>().useGravity = true;
            enemyAgent.enabled = false;
            GetComponent<Animator>().enabled = false;
        }
    }


}
