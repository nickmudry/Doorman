using UnityEngine;
using System.Collections;

public class CharacterMovementScript : MonoBehaviour {

    public GameObject playerModel;

    public float speed;
    public float gravity;

    private Vector3 moveDirection = Vector3.zero;
	
    void Start()
    {
        //start by idle
        playerModel.GetComponent<Animator>().SetInteger("Stance", 0);
    }

	// Update is called once per frame
    void Update()
    {
        //x and z input
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;

        //graity
        moveDirection.y -= gravity * Time.deltaTime;

        //cc magic
        CharacterController cc = GetComponent<CharacterController>();
        cc.Move(moveDirection * Time.deltaTime);

        AnimationChecker();
        
}
    void AnimationChecker()
    {
        playerModel.GetComponent<Animator>().SetInteger("Stance", 0);
        //animation check with rotation
        if (Input.GetKey(KeyCode.D)) //Move Right
        {
            playerModel.GetComponent<Animator>().SetInteger("Stance", 1);
            playerModel.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (Input.GetKey(KeyCode.A)) //Move Left
        {
            playerModel.GetComponent<Animator>().SetInteger("Stance", 1);
            playerModel.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Input.GetKey(KeyCode.W)) //Move Up
        {
            playerModel.GetComponent<Animator>().SetInteger("Stance", 1);
            playerModel.transform.rotation = Quaternion.Euler(0, 90, 0);

        }
        else if (Input.GetKey(KeyCode.S)) //Move Down
        {
            playerModel.GetComponent<Animator>().SetInteger("Stance", 1);
            playerModel.transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        else
        {
            playerModel.GetComponent<Animator>().SetInteger("Stance", 0);
        }
    }
}
