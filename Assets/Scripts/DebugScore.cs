using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugScore : MonoBehaviour
{
    // Declare variables
    int P1Score = 0;
    int P2Score = 0;
    
    [SerializeField]
    public Text P1ScoreText;
    public Text P2ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        P1ScoreText.text = "Player 1 Score: " + P1Score.ToString();
        P2ScoreText.text = "Player 2 Score: " + P2Score.ToString();
    }

    // Update is called once per frame
    public void Update()
    {
        //nothing here
    }

    int IncreaseScore(int score) 
    {
        score += 1;
        return score;
    }

    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.name == "Ball")
        {
            if (name == "Player 1"){
                P1Score = IncreaseScore(P1Score);
                P1ScoreText.text = "Player 1 Score: " + P1Score.ToString();
            }

            if (name == "Player 2"){
                P2Score = IncreaseScore(P2Score);
                P2ScoreText.text = "Player 2 Score: " + P2Score.ToString();
            }
        }
    }
}
