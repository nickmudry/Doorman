using UnityEngine;
using System.Collections;

public class WallScript : MonoBehaviour {
    public bool canBecomeDoor;
    public bool becameDoor;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left Mouse Down on " + gameObject.name);
            if (canBecomeDoor)
            {
               
                BecomeDoor();
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Right Mouse Down on " + gameObject.name);
            if (becameDoor)
            {
                IsNoLongerDoor();
            }
        }
    }

    void BecomeDoor()
    {
        becameDoor = true;
        gameObject.GetComponent<Collider>().isTrigger = true;
        gameObject.GetComponent<Renderer>().material.color = Color.blue;        
    }

    void IsNoLongerDoor()
    {
        becameDoor = false;
        gameObject.GetComponent<Collider>().isTrigger = false;
        gameObject.GetComponent<Renderer>().material.color = Color.white; 
    }

    void CanBecomeDoor(bool canBeDoor)
    {
        canBecomeDoor = canBeDoor;
    }
}
