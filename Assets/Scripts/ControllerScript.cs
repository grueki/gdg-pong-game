using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // Declaring variables
    float moveSpeed;
    // private Text scoreCounterPlayerOne, scoreCounterPlayerTwo;
    // private int playerOneScore, playerTwoScore;
    
    void Start()
    {
        Debug.Log("Intialising Score");
        moveSpeed = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (name == "Player 1")
        {
            float horizontal = Input.GetAxis("Horizontal");
            Vector3 position = transform.position;
            position.x = position.x - moveSpeed * horizontal;
            transform.position = position; 
        }

        else
        {
            float horizontal2 = Input.GetAxis("Horizontal Alt");
            Vector3 position2 = transform.position;
            position2.x = position2.x + moveSpeed * horizontal2;
            transform.position = position2; 
        }
    }
}