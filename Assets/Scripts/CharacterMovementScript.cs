using UnityEngine;
using System.Collections;

public class CharacterMovementScript : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.D)) //Move Right
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector2(speed, 0f));
        }
        if (Input.GetKey(KeyCode.A)) //Move Left
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector2(speed * -1f, 0f));
        }
        if (Input.GetKey(KeyCode.W)) //Move Up
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, speed));
        }
        if (Input.GetKey(KeyCode.S)) //Move Down
        {
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, speed * -1f));
        }
	}
}
