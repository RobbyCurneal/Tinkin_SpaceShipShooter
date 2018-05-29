using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsScript : MonoBehaviour {
    public float xOffset;
    public float yOffset;

    private Rigidbody2D shipRigidBody;
    private Transform shipTransform;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        shipTransform = collision.collider.GetComponentInParent<Transform>();

        if(collision.collider.name == "Player")
            shipTransform.position = new Vector2(shipTransform.position.x + xOffset, shipTransform.position.y + yOffset);
    }
}
