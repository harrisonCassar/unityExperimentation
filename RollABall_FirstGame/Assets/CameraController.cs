using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform player;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        //this refers to object???
        offset = this.transform.position - player.position;
	}
	
	// Update is called once per frame
	void Update () {
        //setting position now
        this.transform.position = player.position + offset;
	}
}
