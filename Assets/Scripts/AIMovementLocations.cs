using UnityEngine;
using System.Collections;

public class AIMovementLocations : MonoBehaviour {
    public Transform[] nodeLocations;
    int currentLocation;
	// Use this for initialization
	void Start () {
        currentLocation = Random.Range(0, nodeLocations.Length);
        gameObject.SendMessage("SetTarget", nodeLocations[currentLocation]);

	}
	
	// Update is called once per frame
	void Update () {
	    if (gameObject.transform == nodeLocations[currentLocation])
        {
            Debug.Log("Reached Location!");
            currentLocation = Random.Range(0, nodeLocations.Length);
            gameObject.SendMessage("SetTarget", nodeLocations[currentLocation]);
        }
	}

    public void FindNewTarget()
    {
        Debug.Log("Reached Location!");
        currentLocation = Random.Range(0, nodeLocations.Length);
        gameObject.SendMessage("SetTarget", nodeLocations[currentLocation]);
    }
}
