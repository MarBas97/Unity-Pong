using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //configuration parameters
     
    [SerializeField] float movespeed = 8.0f;
    // Use this for initialization
    //void Start () {

    //}

    //// Update is called once per frame
    //void Update ()
    //   {      
    //       Move();
    //}

    //   private void Move()
    //   {

    //       if(Input.GetKey("w") && transform.position.y<=maxY)
    //       {
    //           transform.position += new Vector3(0, movespeed * Time.deltaTime, 0);
    //       }
    //       if (Input.GetKey("s") && transform.position.y >=minY)
    //       {
    //           transform.position += new Vector3(0, -movespeed * Time.deltaTime, 0);           
    //       }
    //   }

    void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * movespeed;
    }
}
