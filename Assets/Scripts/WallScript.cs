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

    void OnMouseDown()
    {
        Debug.Log("Mouse Down on " + gameObject.name);
        if (canBecomeDoor)
        {
            becameDoor = true;
            BecomeDoor();
        }
    }

    void BecomeDoor()
    {
        becameDoor = true;
        gameObject.GetComponent<Renderer>().material.color = Color.blue;        
    }

    void CanBecomeDoor(bool canBeDoor)
    {
        canBecomeDoor = canBeDoor;
    }
}
