using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionBroadcast : MonoBehaviour {

    public static float x_position = 0;
    public static float y_position = 0;
    public static float z_position = 0;
    public static Vector3 object_position;
    

    private Rigidbody pulledobject_rb;

	// Use this for initialization
	void Start () {
        pulledobject_rb = gameObject.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        object_position = transform.position;
        pulledobject_rb.AddForce(RealGravity.appliedForce * Time.deltaTime);
    }
}
