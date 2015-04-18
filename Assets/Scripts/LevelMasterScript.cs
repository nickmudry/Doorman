using UnityEngine;
using System.Collections;

public class LevelMasterScript : MonoBehaviour {
    public int startingDoors;
    public int startingSpecialDoors;
    public int pointsInLevel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.F))
        {
            RenderSettings.fog = !RenderSettings.fog;
        }
	}
}
