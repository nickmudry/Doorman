﻿using UnityEngine;
using System.Collections;

public class WallScript : MonoBehaviour {
    public bool canBecomeDoor;
    public bool becameDoor;
    GameObject player;
    GameObject playerDoor;
    public Material door;
    public Material wall;
    GameObject doorObject;
    
    public Color selectedColor = Color.green;

    private Color unselectedColor = Color.white;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        playerDoor = GameObject.Find("playerDoor");
        if (GameObject.Find(gameObject.name + "/Door") != null)
        {
            doorObject = GameObject.Find(gameObject.name + "/Door");
            doorObject.SetActive(false);
        }
        else
        {
            //Do nothing, because this is the floors, and they don't have doors. 
        }
	}
	
    void OnMouseOver()
    {
        if (canBecomeDoor)
        {
            GetComponent<MeshRenderer>().material.color = selectedColor;
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (!becameDoor && canBecomeDoor && player.GetComponent<PlayerInventory>().totalDoors > 0)
            {
                player.SendMessage("UseDoor");
                playerDoor.SetActive(false);
                BecomeDoor();
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (canBecomeDoor && becameDoor)
            {
                player.SendMessage("GiveDoor");
                playerDoor.SetActive(true);
                IsNoLongerDoor();
            }
        }
    }

    void OnMouseExit()
    {
        GetComponent<MeshRenderer>().material.color = unselectedColor;
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
