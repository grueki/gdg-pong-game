using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryFloating : MonoBehaviour
{
    public float FloatStrength;
    public float RandomRotationStrength;
     
     
    void Update () {
        transform.GetComponent<Rigidbody>().AddForce(Vector3.up *FloatStrength);
        transform.Rotate(RandomRotationStrength,RandomRotationStrength,RandomRotationStrength);
    }
}
