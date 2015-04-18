using UnityEngine;
using System.Collections;

public class CharacterMovementScript : MonoBehaviour {
    public float speed;
    public int doorsHeld = 10;
    public GameObject playerSprite;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D)) //Move Right
        {
            playerSprite.transform.rotation = Quaternion.Euler(65, 0, 0);
            gameObject.GetComponent<Rigidbody>().AddForce(transform.right * speed);


        }
        if (Input.GetKey(KeyCode.A)) //Move Left
        {
            //hacky rotate
            playerSprite.transform.rotation = Quaternion.Euler(297, 207, 335);
            gameObject.GetComponent<Rigidbody>().AddForce(-transform.right * speed);


        }
        if (Input.GetKey(KeyCode.W)) //Move Up
        {
            gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * speed);

        }
        if (Input.GetKey(KeyCode.S)) //Move Down
        {
            gameObject.GetComponent<Rigidbody>().AddForce(-transform.forward * speed);
        }
        //checks if moving animate
        if (GetComponent<Rigidbody>().velocity.magnitude > 1)
        {
            if (doorsHeld > 1)
            {
                playerSprite.GetComponent<Animator>().SetInteger("Stance", 1);
            }
            else
            {
                playerSprite.GetComponent<Animator>().SetInteger("Stance", 3);
            }
        }
            //if not moving idle
        else if (doorsHeld > 1 && GetComponent<Rigidbody>().velocity.magnitude < 1)
        {
            playerSprite.GetComponent<Animator>().SetInteger("Stance", 0);
        }
        else
        {
            playerSprite.GetComponent<Animator>().SetInteger("Stance", 4);
        }
    }

    public void doorUsed()
    {
        doorsHeld -= 1;
    }
}
