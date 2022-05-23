using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Declare variables here
    int score;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Intialising Score");
        score = 0;
    } 

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    void OnCollisionEnter(Collision collision){
        IncreaseScore();
    }

    int IncreaseScore() {
        Debug.Log(score);
        return score + 1;
    }

    // [return type] FunctionName(parameter1, parameter 2, parameter...){
    //  Code logic :)
    // }
}


