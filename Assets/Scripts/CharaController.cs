using UnityEngine;

public class CharaController : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] float rotationSpeed = 100.0f;
    Animator anim;

    public GameObject grenadeInHand;
    public Transform rightHandPos;
    public GameObject grenadeToThrow;



    public GameObject fireworks2;
    public GameObject fireworks3;
    public GameObject fireworks4;
    public GameObject fireworks5;
    public GameObject fireworks6;


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
        else if (Input.GetKeyDown("2"))
        {
            anim.SetTrigger("isDancing1");
            RadioFireworks();
        }
        else if (Input.GetKeyDown("g"))
        {
            anim.SetTrigger("isThrowing");
        }
        else if (Input.GetKeyDown("h"))
        {
            anim.SetTrigger("isThrowingNoDive");
        }
        else if (Input.GetKeyDown("1"))
        {
            anim.SetTrigger("isTurningOnRadio");
        }
        else if (Input.GetKeyDown("3"))
        {
            anim.SetTrigger("isDancing2");
        }
        else if (Input.GetKeyDown("4"))
        {
            anim.SetTrigger("isRallying");
        }
        else if (Input.GetKeyDown("5"))
        {
            anim.SetTrigger("isCheering");
        }
        else if (Input.GetKeyDown("q"))
        {
            anim.SetTrigger("isCheering1");
        }
    }


    void PickupGrenade()
    {
        grenadeInHand.SetActive(true);   
    }

    void DisableGrenade()
    {
        grenadeInHand.SetActive(false);

        Instantiate(grenadeToThrow, rightHandPos.position, rightHandPos.rotation).GetComponent<Rigidbody>().AddForce(rightHandPos.forward * 280);

    }

    void RadioFireworks()
    {

        FindObjectOfType<AudioManager>().Play("Fireworks2");
        FindObjectOfType<AudioManager>().Play("Fireworks3");
        FindObjectOfType<AudioManager>().Play("Fireworks4");


        fireworks2.GetComponent<ParticleSystem>().Play();
        fireworks3.GetComponent<ParticleSystem>().Play();
        fireworks4.GetComponent<ParticleSystem>().Play();
        fireworks5.GetComponent<ParticleSystem>().Play();
        fireworks6.GetComponent<ParticleSystem>().Play();

    }
}
