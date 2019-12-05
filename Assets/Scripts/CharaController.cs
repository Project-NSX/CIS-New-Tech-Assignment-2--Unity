using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaController : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] float rotationSpeed = 100.0f;
    Animator anim;

    private void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    void LateUpdate()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;


        transform.Rotate(0, rotation, 0);

        if (translation != 0)
        {
            anim.SetBool("isWalking", true);
            anim.SetFloat("characterSpeed", translation);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                anim.SetBool("isRunning", true);
            }
            else
            {
                anim.SetBool("isRunning", false);
            }
        }
        else
        {
            anim.SetBool("isWalking", false);
        }

        if (Input.GetKeyDown("r"))
        {
            anim.SetTrigger("isPunching");
        }
        else if (Input.GetKeyDown("e"))
        {
            anim.SetTrigger("isKicking");
        }
        else if (Input.GetKeyDown("f"))
        {
            anim.SetTrigger("isFootballKicking");
        }
        else if (Input.GetKeyDown("q"))
        {
            anim.SetTrigger("isDancing");
        }
        else if (Input.GetKeyDown("g"))
        {
            anim.SetTrigger("isThrowing");
        }
    }
}
