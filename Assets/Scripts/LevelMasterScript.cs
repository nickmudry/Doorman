using UnityEngine;
using System.Collections;

public class LevelMasterScript : MonoBehaviour {
    public int startingDoors;
    public int startingSpecialDoors;
    public int pointsInLevel;

    GameObject[] pointObjects;

	// Use this for initialization
	void Start () {
	    pointObjects = GameObject.FindGameObjectsWithTag("Points");
        pointsInLevel = pointObjects.Length;
	}
}
