using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Declare variables here
    int score;
    InputHandler myInputHandler;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Intialising Score");
        myInputHandler = gameObject.GetComponent<InputHandler>();
        score = 0;
    } 

    // Update is called once per frame
    void Update()
    {
        var horizontal = myInputHandler.movementInput.x;
        var vertical = myInputHandler.movementInput.y;
        Debug.Log(horizontal);
    }

    void OnCollisionEnter(Collision collision){
        score = IncreaseScore();
    }

    int IncreaseScore() {
        Debug.Log(score);
        return score + 1;
    }

    // [return type] FunctionName(parameter1, parameter 2, parameter...){
    //  Code logic :)
    // }
}


