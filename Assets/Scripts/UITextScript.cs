using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UITextScript : MonoBehaviour {
    public string textToShow;
    public GameObject player;
    PlayerInventory playerInventory;
    
	// Use this for initialization
	void Start () {
        playerInventory = player.GetComponent<PlayerInventory>();
	}
	
	// Update is called once per frame
	void Update () {
        if (textToShow == "Points")
        {
            gameObject.GetComponent<Text>().text = playerInventory.totalPoints.ToString() + "/" + GameObject.Find("LevelMaster").GetComponent<LevelMasterScript>().pointsInLevel;
        }
        else if (textToShow == "Doors")
        {
            gameObject.GetComponent<Text>().text = playerInventory.totalDoors.ToString();
        }
        else if (textToShow == "Special")
        {
            gameObject.GetComponent<Text>().text = playerInventory.totalSpecialDoors.ToString();
        }
        else
        {
             gameObject.GetComponent<Text>().text = "DEFINE_UI_TEXT";
        }
	}
}
