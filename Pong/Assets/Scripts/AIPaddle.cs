using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddle : MonoBehaviour {

    public float speed = 1.75F;

    //the ball
    Transform ball;

    //the ball's rigidbody 2D
    Rigidbody2D ballRig2D;
    
    
    // Use this for initialization
    void Start ()
    {
        InvokeRepeating("Move", .01F, .02F);
    }
	
	
	
    void Move()
    {

        //finding the ball
        if (ball == null)
        {
            ball = GameObject.FindGameObjectWithTag("ball").transform;
        }
        //setting the ball's rigidbody to a variable
        ballRig2D = ball.GetComponent<Rigidbody2D>();

        //checking x direction of the ball
        if(ballRig2D.velocity.x > 0)
        {                   
            //moving down
            if (ball.position.y < transform.position.y - .5F)
            {
                
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            //moving up
            else if (ball.position.y > transform.position.y + .5F)
            {
                
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
        }


        
    }
}

