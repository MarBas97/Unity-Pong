using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Ball : MonoBehaviour
{


    //configuration parameters
    
  
    [SerializeField] float speed = 8F;

    //state 
    private Vector2 spawnDir;
    Vector2 paddleToBallVector;
     public Rigidbody2D rig2D;
    // Use this for initialization
    void Start ()
    {
        StartCoroutine(Pause());
    }
	

    private void LaunchBall()
    {
        if(true)
        {
            
            rig2D = this.gameObject.GetComponent<Rigidbody2D>();

            //generating random number based on possible initial directions
            int rand = UnityEngine.Random.Range(1, 5);

            //setting initial direction
            if (rand == 1)
            {
                spawnDir = new Vector2(.7f, .7f);
            }
            else if (rand == 2)
            {
                spawnDir = new Vector2(.7f, -0.7f);
            }
            else if (rand == 3)
            {
                spawnDir = new Vector2(-0.7f, -0.7f);
            }
            else if (rand == 4)
            {
                spawnDir = new Vector2(-0.7f, 0.1f);
            }

            //moving ball in initial direction and adding speed
            
            rig2D.velocity = (spawnDir * speed);
        }
    }
    IEnumerator Pause()
    {
        yield return new WaitForSeconds(0.5f);
        LaunchBall();
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        

        // Hit the left Racket?
        if (col.gameObject.tag == "Player")
        {
            
            // Calculate hit Factor
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(1, y).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        // Hit the right Racket?
        if (col.gameObject.tag == "Ai")
        {
            // Calculate hit Factor
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(-1, y).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    }

    
    float hitFactor(Vector2 ballPos, Vector2 racketPos,
                float racketHeight)
    {
       
        return (ballPos.y - racketPos.y) / racketHeight;
    }


}
