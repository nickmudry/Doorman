using UnityEngine;
using System.Collections;

public class WallScript : MonoBehaviour {
    public bool canBecomeDoor;
    public bool becameDoor;
    GameObject player;
    public Material door;
    public Material wall;
    GameObject doorObject;
    
    public Color selectedColor = Color.green;

    private Color unselectedColor = Color.white;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        doorObject = GameObject.Find(gameObject.name + "/Door");
        doorObject.SetActive(false);
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
        doorObject.SetActive(true);

    }

    void IsNoLongerDoor()
    {
        becameDoor = false;
        gameObject.GetComponent<Collider>().isTrigger = false;
        gameObject.GetComponent<Renderer>().material = wall;
        doorObject.SetActive(false);
    }

    public void CanBecomeDoor(bool canBeDoor)
    {
        canBecomeDoor = canBeDoor;
    }
}
