using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMovement : MonoBehaviour {
    public float speed;
    public float xBounds;
    private bool goingRight = true;
    private float yPos;
	// Use this for initialization
	void Start () {
        yPos = transform.position.y;

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (goingRight)
        {
            transform.position = new Vector2((transform.position.x + speed), yPos);
            if(transform.position.x > xBounds)
            {
                goingRight = !goingRight;
            }
        }
        if (!goingRight)
        {
            transform.position = new Vector2((transform.position.x - speed), yPos);
            if (transform.position.x < -xBounds)
            {
                goingRight = !goingRight;
            }
        }
	}
}
