using UnityEngine;
using System.Collections;

public class PlayerInventory : MonoBehaviour {
    public int totalDoors;
    public int totalSpecialDoors;
    public int totalPoints; 

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void UseDoor()
    {
        totalDoors -= 1;
    }
    public void GiveDoor()
    {
        totalDoors += 1;
    }
}
