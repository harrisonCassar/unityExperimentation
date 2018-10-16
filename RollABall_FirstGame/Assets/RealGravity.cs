using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealGravity : MonoBehaviour
{
    //public float ForceMultiplier = 1;
    //private float force = 1;

    private float x_object;
    private float y_object;
    private float z_object;
    private float distance;
    public static Vector3 appliedForce;
    private Vector3 pos;
    public float baseGravityForce = 1;
    private float appliedForceScalar = 1;

    public Vector3 positionalDifference;

    //private Rigidbody player_rb;

    //public float;

    // Use this for initialization
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        x_object = PositionBroadcast.x_position;
        y_object = PositionBroadcast.y_position;
        z_object = PositionBroadcast.z_position;

        distance = PositionBroadcast.object_position.magnitude - transform.position.magnitude;

        appliedForceScalar = baseGravityForce / (distance * distance);

        positionalDifference = pos - PositionBroadcast.object_position;

        appliedForce = positionalDifference.normalized * appliedForceScalar;
    }
}
