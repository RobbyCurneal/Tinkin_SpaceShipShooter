using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_Movement : MonoBehaviour {

    public int playerSpeed = 25;
    public float moveX;
    public float moveY;
    public Rigidbody2D bullet;
    public int bulletSpeed;
    public int fireRate;
    private Rigidbody2D rigidBody;
    private int counter;
    private float rotation = 0;
    public float rotX = 0;
    public float rotY = 0;
    
    
    // Use this for initialization
	void Start () {
        counter = fireRate;
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        playerMove();

        if ((counter == fireRate && Input.GetButton("Fire1")))
        {
            fireGuns();
        }
        
        if(counter != fireRate)
        {
            counter++;
        }
	}

    void playerMove()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

        
        rigidBody.velocity = new Vector2(moveX * playerSpeed, moveY * playerSpeed);

    }

    void fireGuns()
    {
         Rigidbody2D bulletInstance1 = Instantiate(bullet, new Vector2(transform.position.x - 0.4f, transform.position.y + 2.5f), transform.rotation) as Rigidbody2D;
         Rigidbody2D bulletInstance2 = Instantiate(bullet, new Vector2(transform.position.x + 0.4f, transform.position.y + 2.5f), transform.rotation) as Rigidbody2D;

         bulletInstance1.velocity = new Vector2(0, bulletSpeed);
         bulletInstance2.velocity = new Vector2(0, bulletSpeed);

        Physics2D.IgnoreCollision(bulletInstance1.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(bulletInstance2.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        Physics2D.IgnoreLayerCollision(8, 9);
        Physics2D.IgnoreLayerCollision(8, 13);


        counter = 0;
    }

}
