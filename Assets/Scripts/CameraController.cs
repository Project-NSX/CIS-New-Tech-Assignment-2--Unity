using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotationSpeed = 1;
    public Transform target, player;
    float mouseX, mouseY;
    // Speed of rotation of the player
    float rotSpeed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate()
    {
        CamControl();    
    }

    void CamControl()
    {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;

        mouseY = Mathf.Clamp(mouseY, -35, 60);


        transform.LookAt(target);

        if (Input.GetKey("w") || Input.GetKey("s"))
        {

            // Specifies the goal along X and Z but not on Y
            Vector3 lookAtGoal = new Vector3(target.position.x, this.transform.position.y, target.position.z);
            // Make NPC face the direction of the goal
            Vector3 direction = lookAtGoal - this.transform.position;

            player.rotation = Quaternion.Slerp(player.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);


            //player.rotation = Quaternion.Euler(0, mouseX, 0);
            target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        }
        else 
        {
            target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        }

    }
}
