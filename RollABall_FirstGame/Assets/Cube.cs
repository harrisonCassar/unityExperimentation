using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	private void OnTriggerEnter(Collider other) //collider other refers to player
    {
        if (other.CompareTag("Player")) //checks to see if object that entered collider area is named "player"
        {
            //this refers to object that we are attached to
            Destroy(this.gameObject);
        }
    }
}
