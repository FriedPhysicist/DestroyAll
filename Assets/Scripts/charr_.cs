using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charr_ : MonoBehaviour
{

    public Rigidbody rb;
    float x_axis;
    public float speed;
    public float turn_multiplier;
    public GameObject ball;





    // Update is called once per frame
    void Update()
    { 
        x_axis=Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        normal_state();
        //transform.LookAt(ball.transform.position);
    }

    void normal_state()
    { 
        rb.velocity=new Vector3(x_axis*speed/4, rb.velocity.y,speed);

        while(x_axis!=0)
        {
            transform.rotation=Quaternion.Euler(transform.rotation.x+Mathf.Abs(x_axis)*turn_multiplier,transform.rotation.y+x_axis*turn_multiplier,0); 
            break;
        } 

        ball.transform.Rotate(5f,0f,0f); 
    }
}
