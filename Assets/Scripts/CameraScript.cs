using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    public GameObject cursor;

    public Transform target;
    public Transform target2;

    public float dampTime = 0.15f;

    private Vector3 velocity = Vector3.zero;
	// Use this for initialization
	void Start () {
        cursor = GameObject.Find("Cursor");
	}
	
	// Update is called once per frame
	void Update () {
        Dampener();
        
	}

    //void RotateCamera()
    //{
    //    if (Input.GetKeyDown(KeyCode.E))
    //    {

    //    }
    //}

    void Dampener()
    {
        cursor.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
        cursor.transform.position = target2.transform.position;
        //Vector3 point = GetComponent<Camera>().WorldToViewportPoint(target.position);
        //Vector3 point2 = GetComponent<Camera>().WorldToViewportPoint(target2.position);
        Vector3 delta = ((target.position + target2.position) / 2) - GetComponent<Camera>().ViewportToWorldPoint(new Vector3(.5f, .5f, 5));
        Vector3 destination = transform.position + delta;

        transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
    }
}
