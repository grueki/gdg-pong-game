using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoGoingThroughWallsThankYou : MonoBehaviour
{
    // Declaring variables
    float posBoundary = 44.5f;
    float negBoundary = -44.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= posBoundary)
        {
            transform.position = new Vector3(posBoundary, 4, transform.position.z);
        }

        if (transform.position.x <= negBoundary)
        {
            transform.position = new Vector3(negBoundary, 4, transform.position.z);
        }
    }
}
