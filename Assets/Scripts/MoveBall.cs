using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    float moveSpeedBall;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Setting Ball Speed");
        moveSpeedBall = 15f;
        Launch();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float z = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector3(moveSpeedBall * x, 5, moveSpeedBall * z);
    }
}
