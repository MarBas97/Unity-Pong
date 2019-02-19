using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnerControler : MonoBehaviour
{

    [SerializeField] GameObject ball;
    // Use this for initialization
    void Start ()
    {
        GameObject ballClone;
        ballClone = Instantiate(ball, this.transform.position, this.transform.rotation) as GameObject;
        ballClone.transform.SetParent(this.transform);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.childCount == 0)
        {
            GameObject ballClone;
            ballClone = Instantiate(ball, this.transform.position, this.transform.rotation) as GameObject;
            ballClone.transform.SetParent(this.transform);
        }
    }
    
    
}
