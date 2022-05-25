using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    // Declare variables here
    int score;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HELLOOOOO");
        score = 0;
    } 

    // // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("P2_horizontal") != 0){
            float horizontal2 = Input.GetAxis("P2_horizontal");
            Debug.Log(horizontal2);
            Vector3 positionP2 = transform.position;
            positionP2.x = positionP2.x + 0.1f * horizontal2;
            transform.position = positionP2; 
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


