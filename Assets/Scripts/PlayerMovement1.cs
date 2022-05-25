using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
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
    void Update()
    {
        //Debug.Log(horizontal);
        if(Input.GetAxis("P1_horizontal") != 0){
            float horizontal1 = Input.GetAxis("P1_horizontal");
            Vector3 positionP1 = transform.position;
            positionP1.x = positionP1.x + 0.1f * horizontal1;
            transform.position = positionP1; 
        }
        
         
    }

    void OnCollisionEnter(Collision collision){
        score = IncreaseScore();
    }

    int IncreaseScore() {
        //Debug.Log(score);
        return score + 1;
    }
}


