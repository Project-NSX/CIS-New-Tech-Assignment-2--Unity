using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kick : StateMachineBehaviour
{
    GameObject[] legsGO;
    CapsuleCollider[] legCols;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        legsGO = GameObject.FindGameObjectsWithTag("PlayerColliders");
        
        foreach(GameObject i in legsGO)
        {
            i.GetComponent<CapsuleCollider>().enabled = true;
     
        }
       
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        foreach (GameObject i in legsGO)
        {
            i.GetComponent<CapsuleCollider>().enabled = false;
        }
    }
}
