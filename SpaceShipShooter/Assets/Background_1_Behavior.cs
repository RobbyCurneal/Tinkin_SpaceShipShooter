using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_1_Behavior : MonoBehaviour {
    public float speed;
    public Rigidbody2D body;
    public Rigidbody2D Copy;
    private bool createdCopy = false;

	// Use this for initialization
	void Start () {
        body.velocity = new Vector2(0, -speed);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if(!createdCopy && gameObject.transform.position.y < 0)
        { 
            Rigidbody2D backGroundCopy = Instantiate(Copy, new Vector2(transform.position.x, 83), transform.rotation) as Rigidbody2D;
            backGroundCopy.velocity = new Vector2(0, speed);
            backGroundCopy.GetComponent<Background_1_Behavior>().speed = speed;
            createdCopy = !createdCopy;
        }
        if(gameObject.transform.position.y <= -80)
        {
            Destroy(gameObject);
        }
	}
}
