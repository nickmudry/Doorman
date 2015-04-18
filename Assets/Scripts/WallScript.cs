using UnityEngine;
using System.Collections;

public class WallScript : MonoBehaviour {
    public bool canBecomeDoor;
    public bool becameDoor;
    GameObject player;
    public Material door;
    public Material wall;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!becameDoor && canBecomeDoor && player.GetComponent<PlayerInventory>().totalDoors > 0)
            {
                player.SendMessage("UseDoor");
                BecomeDoor();
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (canBecomeDoor && becameDoor)
            {
                player.SendMessage("GiveDoor");
                IsNoLongerDoor();
            }
        }
    }

    void BecomeDoor()
    {
        becameDoor = true;
        gameObject.GetComponent<Collider>().isTrigger = true;
        gameObject.GetComponent<Renderer>().material = door;
    }

    void IsNoLongerDoor()
    {
        becameDoor = false;
        gameObject.GetComponent<Collider>().isTrigger = false;
        gameObject.GetComponent<Renderer>().material = wall;
    }

    void CanBecomeDoor(bool canBeDoor)
    {
        canBecomeDoor = canBeDoor;
    }
}
