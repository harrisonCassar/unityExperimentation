using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour { //tells Unity that the name of the class is the name of the respective object //MUST BE MATCHING FILE NAME

    //public variable allows for other classes to use same variable
    //Unity also allows for variables of public type to be edited DIRECTLY IN THE UNITY UI :D
    public float speed = 100;

    //gives us access to the rigidbody component of our GameObject
    //private means that only accesible by this class; no one else can see it
    private Rigidbody rb;

	// Use this for initialization; auto run at beginning of scene loading
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>(); //gameObject refers to the object that this script is for
	}
	
	// Update is called once per frame
	void Update () {
        //use Unity's input system because it is CROSS-PLATFORM
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        rb.AddForce(new Vector3(x, 0, z)*speed*Time.deltaTime); //takes a vector in //0 for y because we don't want it moving up/bouncing
        //speed --> multiplies the force to increase it
        //time.deltatime will scale with the framerate of systems to be CONSISTENT (less fps --> less updates, and therefore will increase value)
	}
}
