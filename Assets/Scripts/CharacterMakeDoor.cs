using UnityEngine;
using System.Collections;

public class CharacterMakeDoor : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Wall")
        {
            col.gameObject.GetComponent<WallScript>().CanBecomeDoor(true);
            
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Wall")
        {
            col.gameObject.GetComponent<WallScript>().CanBecomeDoor(false);            
        }
    }
}
