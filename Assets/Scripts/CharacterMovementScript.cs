using UnityEngine;
using System.Collections;

public class CharacterMovementScript : MonoBehaviour {

    public float speed = 6.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    public int doorsHeld = 10;
    public GameObject playerModel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
        //hacky rotate
        if (Input.GetKey(KeyCode.D)) //Move Right
        {
            playerModel.transform.rotation = Quaternion.Euler(0, 180, 0);
            //gameObject.GetComponent<Rigidbody>().velocity = (transform.right * speed);


        }
        if (Input.GetKey(KeyCode.A)) //Move Left
        {
            
            playerModel.transform.rotation = Quaternion.Euler(0, 0, 0);
            //gameObject.GetComponent<Rigidbody>().velocity = (-transform.right * speed);


        }
        if (Input.GetKey(KeyCode.W)) //Move Up
        {
            playerModel.transform.rotation = Quaternion.Euler(0, 90, 0);
            //gameObject.GetComponent<Rigidbody>().velocity = (transform.forward * speed);

        }
        if (Input.GetKey(KeyCode.S)) //Move Down
        {
            playerModel.transform.rotation = Quaternion.Euler(0, -90, 0);
            //gameObject.GetComponent<Rigidbody>().velocity = (-transform.forward * speed);
        }

        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;

        moveDirection.y -= gravity * Time.deltaTime;
        CharacterController cc = GetComponent<CharacterController>();
        cc.Move(moveDirection * Time.deltaTime);

        //checks if moving animate
        if (GetComponent<Rigidbody>().velocity.magnitude > 1)
        {
            if (doorsHeld > 1)
            {
                playerModel.GetComponent<Animator>().SetInteger("Stance", 1);
            }         
            else      
            {         
                playerModel.GetComponent<Animator>().SetInteger("Stance", 3);
            }
        }
            //if not moving idle
        else if (doorsHeld > 1 && GetComponent<Rigidbody>().velocity.magnitude < 1)
        {
            playerModel.GetComponent<Animator>().SetInteger("Stance", 0);
        }         
        else      
        {         
            playerModel.GetComponent<Animator>().SetInteger("Stance", 4);
        }
    }

    public void doorUsed()
    {
        doorsHeld -= 1;
    }
}
