using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBaseFSM : StateMachineBehaviour
{
    // initialise player gameobject
    public GameObject player;
    // Initialise Agent
    public GameObject Agent;
    // Initialise agent
    public UnityEngine.AI.NavMeshAgent enemyAgent;
    // Start is called before the first frame update

    public Animator Anim;

    public override void OnStateEnter(
           Animator animator,
           AnimatorStateInfo stateInfo,
           int layerIndex)
    {

        // Get NPC from animator
        Agent = animator.gameObject;

        // Set Agent
        enemyAgent = Agent.GetComponent<UnityEngine.AI.NavMeshAgent>();

        // Get player from EnemyAI script
        player = Agent.GetComponent<EnemyAI>().GetPlayer();
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Keep agent more tightly on it's path - sourced from AI course by Hollistic3d on Udemy
        if (enemyAgent.hasPath)
        {
            Vector3 toTarget = enemyAgent.steeringTarget - enemyAgent.transform.position;
            float turnAngle = Vector3.Angle(enemyAgent.transform.forward, toTarget);
            enemyAgent.acceleration = turnAngle * enemyAgent.speed;
        }
    }
}
