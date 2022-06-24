using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    float moveSpeedBall;
    public Rigidbody rb;
    public Vector3 StartPosition;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Setting Ball Speed");
        moveSpeedBall = 40f;
        Launch();
        StartPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float ResetValue = Input.GetAxisRaw("Reset");
        if (ResetValue != 0)
        {   
            Reset();
            Launch();
        }
    }
    private void Launch()
    {
        float a = (Random.Range(20, 160) * (Random.Range(0,2) * 2 - 1)) * Mathf.Deg2Rad;
        float x = Mathf.Cos(a);
        float z = Mathf.Sin(a);
        Vector3 directionVector = new Vector3(x, 5f, z);
        rb.velocity = directionVector * moveSpeedBall;
        Debug.Log(rb.velocity);
    }

    public void Reset()
    {
        rb.velocity = Vector3.zero;
        transform.position = StartPosition;
    }

    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.name == "Boundary1")
        {
            Reset();
            Launch();
        }
        if (collision.gameObject.name == "Boundary2")
        {
            Reset();
            Launch();
        }
    }
    
}
