using UnityEngine;
using System.Collections;

public class LevelMasterScript : MonoBehaviour {
    public int startingDoors;
    public int startingSpecialDoors;
    public int pointsInLevel;
    public int pointsCollected;

    GameObject playerObject;
    GameObject[] pointObjects;

	// Use this for initialization
	void Start () {
	    pointObjects = GameObject.FindGameObjectsWithTag("Points");
        pointsInLevel = pointObjects.Length;
        playerObject = GameObject.Find("Player");
	}

    void Update()
    {
        pointsCollected = playerObject.GetComponent<PlayerInventory>().totalPoints;
        if (pointsCollected == pointsInLevel)
        {
            Application.LoadLevel(Application.loadedLevel + 1);
        }
    }
}
