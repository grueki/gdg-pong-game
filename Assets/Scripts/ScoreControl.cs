using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreControl : MonoBehaviour
{
    // Declare variables
    int P1Score;
    int P2Score;
    // Start is called before the first frame update
    void Start()
    {
        P1Score = 0;
        P2Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int IncreaseScore(int score) 
    {
        return score + 1;
    }

    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.name == "Ball")
        {
            if (name == "Player 1"){
                P1Score = IncreaseScore(P1Score);
                Debug.Log("Player 1's score: " + P1Score);
            }

            if (name == "Player 2"){
                P2Score = IncreaseScore(P2Score);
                Debug.Log("Player 2's score: " + P2Score);
            }
        }
    }
}
