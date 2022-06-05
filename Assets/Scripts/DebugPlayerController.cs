using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugPlayerController : MonoBehaviour
{
    // Declaring variables
    float moveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Intialising Score");
        moveSpeed = 0.5f;
    }

    // Update is called once per frame
    void Update() 
    {
        float horizontal = Input.GetAxis("Horizontal");
        float horizontal2 = Input.GetAxis("Horizontal Alt");

        if (horizontal != 0)
        {
            if (name == "Player 1"){
                Vector3 position = transform.position;
                position.x = position.x - moveSpeed * horizontal;
                transform.position = position; 
                }
        }

        if (horizontal2 != 0)
        {
            if (name == "Player 2"){
            Vector3 position2 = transform.position;
            position2.x = position2.x + moveSpeed * horizontal2;
            transform.position = position2; 
            }
        } 
    }
}
